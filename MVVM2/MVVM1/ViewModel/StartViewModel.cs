﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM1.ViewModel
{
    public class StartViewModel : BindableBase
    {

        public ObservableCollection<string> controllers { get; set; }
        private string chosenSetup;
        private string controllerName;
        public MyICommand routeCommand { get; set; }

        public StartViewModel() {

            loadControllers();
            routeCommand = new MyICommand(onRoute);

        }

        private void onRoute() {

        }

        private void loadControllers() {

            ResDbEntities rde = new ResDbEntities();

            ObservableCollection<string> Controllers =
                new ObservableCollection<string>();

            Controllers.Add("New Local Controller");
            foreach (LkRe lkre in rde.LkRes.ToList()) {
                Controllers.Add(lkre.name);
            }

            controllers = Controllers;

        }

        public string ChosenSetup {
            get { Console.WriteLine($"Got {chosenSetup}"); return chosenSetup;}
            set {
                if (chosenSetup != value) {
                    chosenSetup = value;
                    OnPropertyChanged("ChosenSetup");
                    Console.WriteLine($"Changed setup. Bind successfull! {chosenSetup}");
                }
            }
        }

        public string ControllerName {
            get { Console.WriteLine($"Got {controllerName}"); return controllerName;}
            set {
                if (controllerName != value) {
                    controllerName = value;
                    OnPropertyChanged("ControllerName");
                    Console.WriteLine($"Changed controller name. Bind successfull! {controllerName}");
                }
            }
        }
    }
}
