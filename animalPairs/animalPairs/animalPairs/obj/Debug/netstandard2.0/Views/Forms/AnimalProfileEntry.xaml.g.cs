//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("animalPairs.Views.Forms.AnimalProfileEntry.xaml", "Views/Forms/AnimalProfileEntry.xaml", typeof(global::animalPairs.Views.Forms.AnimalProfileEntry))]

namespace animalPairs.Views.Forms {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\Forms\\AnimalProfileEntry.xaml")]
    public partial class AnimalProfileEntry : global::Xamarin.Forms.ContentView {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::animalPairs.Controls.BorderlessEntry AnimalName;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label AnimalAge;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::animalPairs.Controls.BorderlessEntry Age;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label AnimalType;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Picker AnimalTypePicker;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::animalPairs.Controls.BorderlessEditor Description;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::animalPairs.Controls.BorderlessEntry Password;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(AnimalProfileEntry));
            AnimalName = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::animalPairs.Controls.BorderlessEntry>(this, "AnimalName");
            AnimalAge = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "AnimalAge");
            Age = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::animalPairs.Controls.BorderlessEntry>(this, "Age");
            AnimalType = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "AnimalType");
            AnimalTypePicker = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Picker>(this, "AnimalTypePicker");
            Description = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::animalPairs.Controls.BorderlessEditor>(this, "Description");
            Password = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::animalPairs.Controls.BorderlessEntry>(this, "Password");
        }
    }
}