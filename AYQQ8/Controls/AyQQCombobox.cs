using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Ay.Framework.WPF.Controls;

namespace AYQQ8.Controls
{

    [TemplateVisualState(Name = "MinItem", GroupName = "AYQQSelectState")]
    [TemplateVisualState(Name = "MiddleItem", GroupName = "AYQQSelectState")]
    [TemplateVisualState(Name = "SelectItem", GroupName = "AYQQSelectState")]
    [TemplatePart(Name = "PART_CloseButton", Type = typeof(Button))]
    public class AyQQComboBoxItem : ComboBoxItem
    {
        public int QQSelectState
        {
            get { return (int)GetValue(QQSelectStateProperty); }
            set
            {
                SetValue(QQSelectStateProperty, value);
                ChangeVisualState(true);
            }
        }

        static AyQQComboBoxItem() {
            IsSelectedProperty.OverrideMetadata(
               typeof(AyQQComboBoxItem),
               new FrameworkPropertyMetadata(new PropertyChangedCallback(IsSelectedChanged)));
        }

        private static void IsSelectedChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            AyQQComboBoxItem itb = sender as AyQQComboBoxItem;
            if (itb != null) {
                itb.BaseMouseEnter();
            }
        }

        public AyQQComboBoxItem PrewItem
        {
            get { return (AyQQComboBoxItem)GetValue(PrewItemProperty); }
            set { SetValue(PrewItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PrewItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PrewItemProperty =
            DependencyProperty.Register("PrewItem", typeof(AyQQComboBoxItem), typeof(AyQQComboBoxItem), new PropertyMetadata(null));

        public AyQQComboBoxItem LastItem
        {
            get { return (AyQQComboBoxItem)GetValue(LastItemProperty); }
            set { SetValue(LastItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LastItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LastItemProperty =
            DependencyProperty.Register("LastItem", typeof(AyQQComboBoxItem), typeof(AyQQComboBoxItem), new PropertyMetadata(null));



        // Using a DependencyProperty as the backing store for QQSelectState.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty QQSelectStateProperty =
            DependencyProperty.Register("QQSelectState", typeof(int), typeof(AyQQComboBoxItem), new PropertyMetadata(1));



        protected override void OnMouseEnter(MouseEventArgs e)
        {
            BaseMouseEnter();

            base.OnMouseEnter(e);
        }

        internal void BaseMouseEnter()
        {
            if (PrewItem != null)
            {
                PrewItem.QQSelectState = 2;
                SetSmallItem1(PrewItem);
            }
            if (LastItem != null)
            {
                LastItem.QQSelectState = 2;
                SetSmallItem2(LastItem);
            }
            this.QQSelectState = 3;
        }

        private void SetSmallItem1(AyQQComboBoxItem cbo)
        {
            if (cbo != null && cbo.PrewItem != null)
            {
                cbo.PrewItem.QQSelectState = 1;
                SetSmallItem1(cbo.PrewItem);
            }
        }
        private void SetSmallItem2(AyQQComboBoxItem cbo)
        {
            if (cbo != null && cbo.LastItem != null)
            {
                cbo.LastItem.QQSelectState = 1;
                SetSmallItem2(cbo.LastItem);
            }
        }

        private void ChangeVisualState(bool useTransitions)
        {
            if (this.QQSelectState == 1)
            {
                VisualStateManager.GoToState(this, "MinItem", useTransitions);
            }
            else if (this.QQSelectState == 2)
            {
                VisualStateManager.GoToState(this, "MiddleItem", useTransitions);
            }
            else if (this.QQSelectState == 3)
            {

                VisualStateManager.GoToState(this, "SelectItem", useTransitions);
            }
        }
        public override void OnApplyTemplate()
        {
            Button benDeleteItem = GetTemplateChild("PART_CloseButton") as Button;
            if (benDeleteItem != null)
            {
                benDeleteItem.Click += BenDeleteItem_Click;
            }
            base.OnApplyTemplate();
            this.ChangeVisualState(false);
        }

        private void BenDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            AyQQComboBox container = this.Parent as AyQQComboBox;
            if (container != null) {
                container.deleteItem(this);
            }
            e.Handled = true;
        }

        public Visibility NickNameVisibility
        {
            get { return (Visibility)GetValue(NickNameVisibilityProperty); }
            set { SetValue(NickNameVisibilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NickNameVisibility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NickNameVisibilityProperty =
            DependencyProperty.Register("NickNameVisibility", typeof(Visibility), typeof(AyQQComboBoxItem), new PropertyMetadata(Visibility.Collapsed));




        public string ItemHeader
        {
            get { return (string)GetValue(ItemHeaderProperty); }
            set { SetValue(ItemHeaderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemHeader.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemHeaderProperty =
            DependencyProperty.Register("ItemHeader", typeof(string), typeof(AyQQComboBoxItem), new PropertyMetadata(null));

        public string AyNumber
        {
            get { return (string)GetValue(AyNumberProperty); }
            set { SetValue(AyNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AyNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AyNumberProperty =
            DependencyProperty.Register("AyNumber", typeof(string), typeof(AyQQComboBoxItem), new PropertyMetadata(null));

        public string NickName
        {
            get { return (string)GetValue(NickNameProperty); }
            set { SetValue(NickNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NickName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NickNameProperty =
            DependencyProperty.Register("NickName", typeof(string), typeof(AyQQComboBoxItem), new PropertyMetadata(null));






    }


    public class AyQQComboBox : AyComboBox
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new AyQQComboBoxItem();
        }
        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            // return true;
            return (item is AyQQComboBoxItem);
        }
        public delegate void DeleteItemEvent(object obj);
        public DeleteItemEvent deleteItem;
    }

 
}
