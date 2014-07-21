﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Thinktecture.IdentityServer.Resources.Models.Configuration {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class OAuth2Configuration {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OAuth2Configuration() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Thinktecture.IdentityServer.Resources.Models.Configuration.OAuth2Configuration", typeof(OAuth2Configuration).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable Code Flow.
        /// </summary>
        public static string EnableCodeFlow {
            get {
                return ResourceManager.GetString("EnableCodeFlow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This flow is for web applications..
        /// </summary>
        public static string EnableCodeFlowDescription {
            get {
                return ResourceManager.GetString("EnableCodeFlowDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable Consent Page.
        /// </summary>
        public static string EnableConsent {
            get {
                return ResourceManager.GetString("EnableConsent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies whether a consent page is shown before a token/code is returned..
        /// </summary>
        public static string EnableConsentDescription {
            get {
                return ResourceManager.GetString("EnableConsentDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable Implicit Flow.
        /// </summary>
        public static string EnableImplicitFlow {
            get {
                return ResourceManager.GetString("EnableImplicitFlow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This flow is for native apps and client web applications..
        /// </summary>
        public static string EnableImplicitFlowDescription {
            get {
                return ResourceManager.GetString("EnableImplicitFlowDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable JWT Bearer Flow.
        /// </summary>
        public static string EnableJwtBearerFlow {
            get {
                return ResourceManager.GetString("EnableJwtBearerFlow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This flow is for authorizing a resourse using a JWT bearer assertion..
        /// </summary>
        public static string EnableJwtBearerFlowDescription {
            get {
                return ResourceManager.GetString("EnableJwtBearerFlowDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable Resource Owner Flow.
        /// </summary>
        public static string EnableResourceOwnerFlow {
            get {
                return ResourceManager.GetString("EnableResourceOwnerFlow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This flow is for trusted applications only. Users enter their credentials directly into the client..
        /// </summary>
        public static string EnableResourceOwnerFlowDescription {
            get {
                return ResourceManager.GetString("EnableResourceOwnerFlowDescription", resourceCulture);
            }
        }
    }
}
