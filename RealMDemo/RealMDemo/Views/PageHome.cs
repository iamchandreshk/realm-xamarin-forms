
using RealMDemo.Models;
using System;
using Xamarin.Forms;

namespace RealMDemo.Views
{
    public class PageHome : ContentPage
    {
        Editor editordog = new Editor();
        Editor editorperson = new Editor();
        Button button = new Button();

        public PageHome()
        {
            editorperson.HeightRequest = 250;
            editordog.HeightRequest = 250;
            Content = new StackLayout
            {
                Children = {
                    editordog,
                    editorperson,
                    button
                }
            };
        }

        protected override void OnAppearing()
        {
            SetData();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Person person = new Person
            {
                Name = "Chandresh Khambhayata",
                Created = DateTime.UtcNow
            };
            Dog dog = new Dog
            {
                Age = 1,
                Name = "Puppy",
                Owner = person
            };
            SetData();
        }

        private void SetData()
        {
            foreach (var d in App.realm.All<Dog>())
            {
                editordog.Text += "Name: " + d.Name + ", Age:" + d.Age + ", Owner: " + d.Owner.Name
                    + ", Created" + d.Owner.Created;
            }
            foreach (var d in App.realm.All<Person>())
            {
                editorperson.Text += "Name: " + d.Name + ", Created:" + d.Created;
            }
            button.Clicked += Button_Clicked;
        }
    }
}
