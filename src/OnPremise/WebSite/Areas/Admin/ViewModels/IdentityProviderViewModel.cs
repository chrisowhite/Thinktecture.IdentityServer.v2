using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Thinktecture.IdentityServer.Models;

namespace Thinktecture.IdentityServer.Web.Areas.Admin.ViewModels
{
    public class IdentityProviderViewModel
    {
        public IdentityProvider Provider { get; set; }

        public void MapAudienceRestrictions()
        {
            this.AudienceRestrictions = null;
            if (this.Provider.AudienceRestrictions != null && this.Provider.AudienceRestrictions.Any())
            {
                this.AudienceRestrictions = this.Provider.AudienceRestrictions.Aggregate((x, y) => x + System.Environment.NewLine + y);
            }
        }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Audience Restrictions", Description = "LFor OAuth2 bearer flow. List of URIs of allowed bearer token audiences.")]
        public string AudienceRestrictions { get; set; }

        public string[] ParsedAudienceRestrictions
        {
            get
            {
                if (this.AudienceRestrictions == null)
                {
                    return new string[0];
                }
                else
                {
                    return this.AudienceRestrictions.Split(new string[] { System.Environment.NewLine }, System.StringSplitOptions.RemoveEmptyEntries);
                }
            }
        }

        public System.Collections.Generic.IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            foreach (var item in ParsedAudienceRestrictions)
            {
                Uri val;
                if (!Uri.TryCreate(item, UriKind.Absolute, out val))
                {
                    yield return new ValidationResult(item + " is not a valid URI", new string[] { "RedirectUris" });
                }
            }
        }
    }
}