using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Firebase;
using Firebase.Database;
using Firebase.Firestore;

namespace animalPairs.Droid
{
    [Activity(Label = "animalPairs", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static FirebaseApp app;
        public static FirebaseFirestore database;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            var options = new FirebaseOptions.Builder()
                        .SetApplicationId("animalpairs-tfg2021")                    
                        .SetApiKey("AIzaSyCe1FTe0vmQPTdIpkSVIM4cSR38AulqmcA") 
                        .SetProjectId("animalpairs-tfg2021")
                        .SetDatabaseUrl("https://animalpairs-tfg2021-default-rtdb.firebaseio.com/") 
                        .SetStorageBucket("animalpairs-tfg2021.appspot.com")
                        .Build();
            if (app == null) {
                app = FirebaseApp.InitializeApp(this, options, "animalPairs");
                database = FirebaseFirestore.GetInstance(app);
            }
            else
            {
                database = FirebaseFirestore.GetInstance(app);
            }
            LoadApplication(new App());

            FirebaseApp.InitializeApp(Application.Context);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}