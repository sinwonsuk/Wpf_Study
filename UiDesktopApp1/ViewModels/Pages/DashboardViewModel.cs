using System;
using UiDesktopApp1.interfaces;
using UiDesktopApp1.Models;
namespace UiDesktopApp1.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        private readonly IDateTime _idateTime;

        private readonly IDataBase<GangnamguPopulation> _iDatabase;


        [ObservableProperty]
        private int _counter = 0;

        [ObservableProperty]
        private string? currentTime = string.Empty;

        [ObservableProperty]
        private string? text = string.Empty;

        public DashboardViewModel(IDateTime dateTime,IDataBase<GangnamguPopulation> database)
        {
            _idateTime = dateTime;

            _iDatabase = database;
        }


      

        [RelayCommand]
        private void OnCounterIncrement()
        {
            var datas = this._iDatabase.Get();

            Counter++;
        }
        [RelayCommand]
        private void OnCounterIncrements()
        {
            this.Text = "clickes";
        }
        [RelayCommand]
        private void OnTextChanged()
        {
            this.CurrentTime = _idateTime.GetcurrentTime().ToString();
        }
    }
}



