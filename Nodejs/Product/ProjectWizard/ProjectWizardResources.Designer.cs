﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.NodejsTools.ProjectWizard {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ProjectWizardResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ProjectWizardResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.NodejsTools.ProjectWizard.ProjectWizardResources", typeof(ProjectWizardResources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to These tools are a free download for your version of Visual Studio that allow you to write, deploy and debug applications for Microsoft Azure in a range of programming languages..
        /// </summary>
        internal static string AzureToolsInstallInstructions {
            get {
                return ResourceManager.GetString("AzureToolsInstallInstructions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This project requires Microsoft Azure Tools for Visual Studio..
        /// </summary>
        internal static string AzureToolsRequired {
            get {
                return ResourceManager.GetString("AzureToolsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your project can still be created, but some manual configuration of your project will be required and features may be missing or limited.
        ///
        ///We recommend installing the latest version of Microsoft Azure Tools for Visual Studio..
        /// </summary>
        internal static string AzureToolsUpgradeInstructions {
            get {
                return ResourceManager.GetString("AzureToolsUpgradeInstructions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your version of Microsoft Azure Tools is not supported by Node.js Tools for Visual Studio..
        /// </summary>
        internal static string AzureToolsUpgradeRecommended {
            get {
                return ResourceManager.GetString("AzureToolsUpgradeRecommended", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Continue
        ///Some manual steps will be required to configure your project..
        /// </summary>
        internal static string ContinueWithoutAzureToolsUpgrade {
            get {
                return ResourceManager.GetString("ContinueWithoutAzureToolsUpgrade", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not show this warning again..
        /// </summary>
        internal static string DontShowAgain {
            get {
                return ResourceManager.GetString("DontShowAgain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Download and install now
        ///You will need to restart Visual Studio after installation..
        /// </summary>
        internal static string DownloadAndInstall {
            get {
                return ResourceManager.GetString("DownloadAndInstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to start wizard: no automation object available..
        /// </summary>
        internal static string ErrorNoDte {
            get {
                return ResourceManager.GetString("ErrorNoDte", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to start wizard: failed to load Node Tools support Package (0x{0:X08}).
        /// </summary>
        internal static string ImportWizardCouldNotStartFailedToLoadPackage {
            get {
                return ResourceManager.GetString("ImportWizardCouldNotStartFailedToLoadPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to start wizard: Unexpected error 0x{0:X08}.
        /// </summary>
        internal static string ImportWizardCouldNotStartUnexpectedError {
            get {
                return ResourceManager.GetString("ImportWizardCouldNotStartUnexpectedError", resourceCulture);
            }
        }
    }
}
