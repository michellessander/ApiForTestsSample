﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiForTestsample.Domain {
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
    internal class DomainResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DomainResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ApiForTestsample.Domain.DomainResource", typeof(DomainResource).Assembly);
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
        ///   Looks up a localized string similar to A categoria do item deve ser informada..
        /// </summary>
        internal static string Categoria_Null_Empty {
            get {
                return ResourceManager.GetString("Categoria_Null_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A descrição do item deve ser informada..
        /// </summary>
        internal static string Descricao_Null_Empty {
            get {
                return ResourceManager.GetString("Descricao_Null_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O item informado na lista deve ser válido..
        /// </summary>
        internal static string Item_Invalido {
            get {
                return ResourceManager.GetString("Item_Invalido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to O nome deve ser informado..
        /// </summary>
        internal static string Nome_Null_Empty {
            get {
                return ResourceManager.GetString("Nome_Null_Empty", resourceCulture);
            }
        }
    }
}