//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("animalPairs.Views.Forms.PasswordEntry.xaml", "Views/Forms/PasswordEntry.xaml", typeof(global::animalPairs.Views.Forms.PasswordEntry))]

namespace animalPairs.Views.Forms {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\Forms\\PasswordEntry.xaml")]
    public partial class PasswordEntry : global::Xamarin.Forms.ContentView {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::animalPairs.Controls.BorderlessEntry Password;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::animalPairs.Utils.ShowPasswordTriggerAction ShowPasswordActualTrigger;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label ValidationLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(PasswordEntry));
            Password = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::animalPairs.Controls.BorderlessEntry>(this, "Password");
            ShowPasswordActualTrigger = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::animalPairs.Utils.ShowPasswordTriggerAction>(this, "ShowPasswordActualTrigger");
            ValidationLabel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "ValidationLabel");
        }
    }
}
