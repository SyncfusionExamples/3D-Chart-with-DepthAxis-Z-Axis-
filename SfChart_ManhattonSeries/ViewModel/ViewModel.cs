using System.Collections.ObjectModel;

namespace SfChart_ManhattonSeries
{
    public class ViewModel
    {
        public ViewModel()
        {
            Data1 = new ObservableCollection<Model>();
            Data2 = new ObservableCollection<Model>();

            Data1.Add(new Model() { XValue = 1, YValue = 20 });
            Data1.Add(new Model() { XValue = 2, YValue = 25 });
            Data1.Add(new Model() { XValue = 3, YValue = 40 });
            Data1.Add(new Model() { XValue = 4, YValue = 30 });
            Data1.Add(new Model() { XValue = 5, YValue = 46 });
            Data1.Add(new Model() { XValue = 6, YValue = 25 });
            Data1.Add(new Model() { XValue = 7, YValue = 40 });
            Data1.Add(new Model() { XValue = 8, YValue = 32 });

            Data2.Add(new Model() { XValue = 1, YValue = 40 });
            Data2.Add(new Model() { XValue = 2, YValue = 50 });
            Data2.Add(new Model() { XValue = 3, YValue = 45 });
            Data2.Add(new Model() { XValue = 4, YValue = 50 });
            Data2.Add(new Model() { XValue = 5, YValue = 70 });
            Data2.Add(new Model() { XValue = 6, YValue = 45 });
            Data2.Add(new Model() { XValue = 7, YValue = 52 });
            Data2.Add(new Model() { XValue = 8, YValue = 50 });
        }

        public ObservableCollection<Model> Data1
        {
            get;
            set;
        }

        public ObservableCollection<Model> Data2
        {
            get;
            set;
        }

    }
}
