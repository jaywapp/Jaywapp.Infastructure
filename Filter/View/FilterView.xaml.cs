using Jaywapp.Infrastructure.Filter.Model;
using System.Windows;
using System.Windows.Controls;

namespace Jaywapp.Infrastructure.Filter.View
{
    /// <summary>
    /// FilterView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FilterView : UserControl
    {
        #region Dependency Properties
        public static readonly DependencyProperty FilterProperty = DependencyProperty.Register(
            nameof(Filter), typeof(FilterGroup), typeof(FilterView), new FrameworkPropertyMetadata(null));
        #endregion

        #region Properties
        public FilterGroup Filter
        {
            get => (FilterGroup)GetValue(FilterProperty);
            set => SetValue(FilterProperty, value);
        }
        #endregion

        #region Constructor
        public FilterView()
        {
            InitializeComponent();
        }
        #endregion

        #region Functions
        private void AddFilter(object sender, RoutedEventArgs e)
        {
            Filter.Children.Add(new CarNameFilter());
            RaisePropertyChanged(nameof(Filter.Children));
        }

        private void AddFilterGroup(object sender, RoutedEventArgs e)
        {
            Filter.Children.Add(new CustomRuleCheckFilterGroup());
            RaisePropertyChanged(nameof(Filter.Children));
        }
        #endregion
    }
}
