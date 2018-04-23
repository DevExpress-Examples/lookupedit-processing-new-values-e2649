using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;

namespace Lookup___How_to_Process_New_Values {
    public partial class MainPage : UserControl {
        ProductList products;
        public MainPage() {
            InitializeComponent();
            products = new ProductList();
            lookUpEdit1.ItemsSource = products;
        }

        Control control;
        private void lookUpEdit1_ProcessNewValue(DependencyObject sender, DevExpress.Xpf.Editors.ProcessNewValueEventArgs e) {
            control = new ContentControl() { Template = (ControlTemplate)Resources["addNewRecordTemplate"] };
            control.Tag = e;
            Product row = new Product();
            row.ProductName = e.DisplayText;
            control.DataContext = row;
            FrameworkElement owner = sender as FrameworkElement;
            DialogClosedDelegate closeHandler = new DialogClosedDelegate(CloseAddNewRecordHandler);
            FloatingContainer.ShowDialogContent(control, owner, Size.Empty, new FloatingContainerParameters() {
                Title = "Add New Record",
                AllowSizing = false,
                ClosedDelegate = closeHandler
            });
            e.PostponedValidation = true;
            e.Handled = true;
        }
        void CloseAddNewRecordHandler(bool? close) {
            if (close != null && (bool)close)
                products.Add(control.DataContext as Product);
            control = null;
        }
    }
}
