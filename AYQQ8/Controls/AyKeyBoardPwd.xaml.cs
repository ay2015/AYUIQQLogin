using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AYQQ8.Controls
{
    /// <summary>
    /// AyKeyBoardPwd.xaml 的交互逻辑
    /// </summary>
    public partial class AyKeyBoardPwd : UserControl
    {
        public AyKeyBoardPwd()
        {
            InitializeComponent();
        }
        bool isfirstload = true;

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (isfirstload)
            {
                this.IsVisibleChanged += AyKeyBoardPwd_IsVisibleChanged;
                var window = Window.GetWindow(this);
                window.KeyDown += UserControl_KeyDown;
                window.KeyUp += UserControl_KeyUp;
                isfirstload = false;
            }
        }

        private void AyKeyBoardPwd_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            bool ff = (bool)e.NewValue;
            if (ff)
            {
                if (Keyboard.IsKeyToggled(Key.CapsLock) == true)
                {
                    capslockChecked = true;
                    btnCapsLock.IsChecked = true;
                }
                else if (btnCapsLock.IsChecked == true)
                {
                    capslockChecked = false;
                    isTriggerLockChecked = false;
                    btnCapsLock.IsChecked = false;
                }

            }

        }

        public FrameworkElement ElementName
        {
            get { return (FrameworkElement)GetValue(ElementNameProperty); }
            set { SetValue(ElementNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ElementName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ElementNameProperty =
            DependencyProperty.Register("ElementName", typeof(FrameworkElement), typeof(AyKeyBoardPwd), new PropertyMetadata(null));



        public object BindElement
        {
            get { return (object)GetValue(BindElementProperty); }
            set { SetValue(BindElementProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BindElement.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BindElementProperty =
            DependencyProperty.Register("BindElement", typeof(object), typeof(AyKeyBoardPwd), new UIPropertyMetadata(new PropertyChangedCallback(BindElementChanged)));

        private void SetSourceFromProperty()
        {
            var expression = this.GetBindingExpression(BindElementProperty);
            if (expression != null && this.ElementName == null)
                this.SetValue(AyKeyBoardPwd.ElementNameProperty, expression.DataItem as FrameworkElement);

        }
        public PasswordBox pb;
        private static void BindElementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var keyboard = d as AyKeyBoardPwd;
            if (keyboard != null)
                keyboard.SetSourceFromProperty();
            if (e.NewValue != null)
            {
                if (string.IsNullOrEmpty(e.NewValue.ToString()))
                {
                    if (keyboard != null)
                    {
                        keyboard.pb = keyboard.ElementName as PasswordBox;
                    }
                }
            }
          
        }
        int uppercase = 1;//默认小写字母
        bool shiftIsChecked = false;
        bool capslockChecked = false;
        private void btnshift_Checked(object sender, RoutedEventArgs e)
        {
            this.Resources["Foreground.Disabled"] = SolidColorBrushConverter.From16JinZhi("#000000");
            this.Resources["Foreground.Enabled"] = SolidColorBrushConverter.From16JinZhi("#888888");
            this.Resources["fontsize.Enabled"] = 9.0;
            this.Resources["fontsize.Disabled"] = 12.0;
            if (uppercase == 1)
            {
                ToUpperCase();
                uppercase = 2;
            }
            else
            {
                ToLowCase();
                uppercase = 1;
            }
            shiftIsChecked = true;
        }

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        private void btnshift_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Resources["Foreground.Disabled"] = SolidColorBrushConverter.From16JinZhi("#888888");
            this.Resources["Foreground.Enabled"] = SolidColorBrushConverter.From16JinZhi("#000000");
            this.Resources["fontsize.Enabled"] = 12.0;
            this.Resources["fontsize.Disabled"] = 9.0;
            if (uppercase == 1)
            {
                ToUpperCase();
                uppercase = 2;
            }
            else
            {
                ToLowCase();
                uppercase = 1;
            }
            shiftIsChecked = false;
        }

        private void ToLowCase()
        {
            foreach (var item in char1.Children)
            {
                Button btn = item as Button;
                btn.Content = (btn.Content as string).ToLower();
            }
            foreach (var item in char2.Children)
            {
                Button btn = item as Button;
                btn.Content = (btn.Content as string).ToLower();
            }
        }
        const int KEYEVENTF_EXTENDEDKEY = 0x1;
        const int KEYEVENTF_KEYUP = 0x2;
        private void btnCapsLock_Checked(object sender, RoutedEventArgs e)
        {
            if (uppercase == 1)
            {
                ToUpperCase();
                uppercase = 2;
            }
            else
            {
                ToLowCase();
                uppercase = 1;
            }
            capslockChecked = true;
            if (isTriggerLockChecked)
            {
                keybd_event(20, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event(20, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
            }
            isTriggerLockChecked = true;
        }

        private void ToUpperCase()
        {
            foreach (var item in char1.Children)
            {
                Button btn = item as Button;
                btn.Content = (btn.Content as string).ToUpper();
            }
            foreach (var item in char2.Children)
            {
                Button btn = item as Button;
                btn.Content = (btn.Content as string).ToUpper();
            }
        }
        bool isTriggerLockChecked = true;
        bool isTriggerShiftChecked = true;

        private void btnCapsLock_Unchecked(object sender, RoutedEventArgs e)
        {
            if (uppercase == 1)
            {
                ToUpperCase();
                uppercase = 2;
            }
            else
            {
                ToLowCase();
                uppercase = 1;
            }
            capslockChecked = false;

            if (isTriggerLockChecked)
            {
                keybd_event(20, 0, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event(20, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
            }
            isTriggerLockChecked = true;
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            Button btntwo = sender as Button;
            if (btntwo != null)
            {
                Canvas btnC = btntwo.Content as Canvas;
                Label uncheckChar = btnC.Children[0] as Label;
                Label checkChar = btnC.Children[1] as Label;
                if (shiftIsChecked)
                {
                    InputCharacter(checkChar.Content.ToString());
                    btnshift.IsChecked = false;
                }
                else
                {
                    InputCharacter(uncheckChar.Content.ToString());
                }
            }
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            Button btnOne = sender as Button;
            if (btnOne != null)
            {
                InputCharacter(btnOne.Content.ToString());
            }
            if (shiftIsChecked)
            {
                btnshift.IsChecked = false;
            }
        }

        public void InputCharacter(string text)
        {
            pb.Password += text;
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyboardDevice.Modifiers & ModifierKeys.Shift) == ModifierKeys.Shift)
            {
                btnshift.IsChecked = true;
            }
        }

        private void UserControl_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.LeftShift || e.Key == Key.RightShift))
            {
                btnshift.IsChecked = false;
            }
            if (e.Key == Key.CapsLock & Keyboard.IsKeyToggled(Key.CapsLock) == true)
            {
                isTriggerLockChecked = false;
                btnCapsLock.IsChecked = true;

            }
            else if (e.Key == Key.CapsLock & Keyboard.IsKeyToggled(Key.CapsLock) == false)
            {
                isTriggerLockChecked = false;
                btnCapsLock.IsChecked = false;

            }
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            string a = pb.Password;
            if (a.Length > 0) {
                pb.Password = a.Remove(a.Length - 1, 1);
            }
           
        }
    }
}
