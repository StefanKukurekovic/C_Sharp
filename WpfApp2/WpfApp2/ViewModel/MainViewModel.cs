using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System;
using GalaSoft.MvvmLight.CommandWpf;

namespace WpfApp2.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private CarVm selectedData;

        // Provides notifications when items get added, removed, or when the whole list is refreshed
        public ObservableCollection<CarVm> Data { get; set; }
        public RelayCommand SellBtnClicked { get; set; }

        public CarVm SelectedData
        {
            get { return selectedData; }
            set { selectedData = value; RaisePropertyChanged(); }
        }


        public MainViewModel()
        {
            Data = new ObservableCollection<CarVm>();

            LoadData();
            SellBtnClicked = new RelayCommand(() =>
                            {
                                SelectedData.Verfuegbarkeit--;
                                // Refreshes the page (we add the same item, and then delete it 
                                // in order to refresh the program
                                Data.Insert(Data.IndexOf(SelectedData) + 1, SelectedData);
                                Data.RemoveAt(Data.IndexOf(SelectedData));},
                                
                                () => { if (selectedData == null) return false;
                                    if (selectedData.Verfuegbarkeit > 0)
                                    { return true; }
                                    else { return false; } }
                                );
        }

        private void LoadData()
        {
            Data.Add(new CarVm("BMW", "M4", 120000, 2018, "Alpiweiﬂ", 430, 5));
            Data.Add(new CarVm("Ford", "Mustang", 80000, 2018, "Magnetic Grey", 450, 10));
            Data.Add(new CarVm("Nissan", "Nismo", 130000, 2018, "Katsura Orange", 650, 7));
            Data.Add(new CarVm("Porsche", "GtR", 400000, 2018, "Carrera", 700, 1));
        }
    }
}