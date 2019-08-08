using Ay.Framework.WPF;
using Ay.Framework.WPF.Controls;
using Ay.Framework.WPF.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
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
using AYQQ8.Controls;
using System.IO;

namespace AYQQ8
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : AyWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            windowcontent.Transition = entranceWindow;

            base.WindowEntranceBackgroundMode = 1;

        }

        public object LoginWindowType
        {
            get { return (object)GetValue(LoginWindowTypeProperty); }
            set { SetValue(LoginWindowTypeProperty, value); }
        }
        static AyLoginFrontWindow front = new AyLoginFrontWindow();
        static AyLoginBackWindow back = new AyLoginBackWindow();
        // Using a DependencyProperty as the backing store for LoginWindowType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LoginWindowTypeProperty =
            DependencyProperty.Register("LoginWindowType", typeof(object), typeof(MainWindow), new PropertyMetadata(null));
        //Ay.Framework.WPF.Controls.Transitions.Transition entranceWindow = AyTransitionGetter.AyTransitionOneWay()[34]; //7
        //Ay.Framework.WPF.Controls.Transitions.Transition exitWindow = AyTransitionGetter.AyTransitionOneWay()[35]; //30

        Ay.Framework.WPF.Controls.Transitions.Transition entranceWindow = AyTransitionGetter.AyTransitionOneWay()[34]; //7
        Ay.Framework.WPF.Controls.Transitions.Transition exitWindow = AyTransitionGetter.AyTransitionOneWay()[35]; //30

        Ay.Framework.WPF.Controls.Transitions.Transition fronttoback = AyTransitionGetter.AyTransitionOneWay()[24];
        Ay.Framework.WPF.Controls.Transitions.Transition backtofront = AyTransitionGetter.AyTransitionOneWay()[25];
        public void ShowFrontWindow()
        {
            LoginWindowType = front;
            windowcontent.Transition = fronttoback;
        }
        public void ShowBackWindow()
        {
            LoginWindowType = back;
            windowcontent.Transition = backtofront;
        }


        private void btnShowBack_Click(object sender, RoutedEventArgs e)
        {
            ShowBackWindow();
        }
        private void btnShowFront_Click(object sender, RoutedEventArgs e)
        {
            ShowFrontWindow();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            windowcontent.Transition = exitWindow;
            LoginWindowType = null;
            AyTime.setTimeout(500, () =>
            {
                base.DoCloseWindow();
            });
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            base.DoMinWindow();
        }

        private void AyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoginWindowType = front;
            AyTime.setTimeout(500, () =>
            {
                windowcontent.Transition = fronttoback;
            });//这个动画是在8秒后完成
        }



        private void AyHyberTextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://zc.qq.com/chs/index.html");
        }

        private void AyHyberTextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://aq.qq.com/cn2/findpsw/pc/pc_find_pwd_input_account");
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            
            AyMessageBox.ShowInformation("你的用户名:"+cbo.Text+",用户密码:"+ wpb.Password + ",登录成功..");
        }

        private void closeWindow_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (e.KeyboardDevice.IsKeyDown(Key.Tab))
            {
                cbo.Focus();
            }

        }
        AyQQComboBox cbo;
        AyTextBox email;
        private void UserName_Loaded(object sender, RoutedEventArgs e)
        {
            if (cbo == null)
            {
                cbo = sender as AyQQComboBox;
                AyQQComboBoxItem qqItem = new AyQQComboBoxItem();
                qqItem.ItemHeader = Directory.GetCurrentDirectory() + "/Contents/Images/login/1.jpg";
                qqItem.NickName = "AY";
                qqItem.AyNumber = "875556003";
                qqItem.Content = "875556003";

                AyQQComboBoxItem qqItem2 = new AyQQComboBoxItem();
                qqItem2.ItemHeader = Directory.GetCurrentDirectory() + "/Contents/Images/login/2.jpg";
                qqItem2.NickName = "ayjs";
                qqItem2.AyNumber = "admin@ayjs.net";
                qqItem2.Content = "admin@ayjs.net";
                qqItem2.PrewItem = qqItem;
                qqItem.LastItem = qqItem2;

                AyQQComboBoxItem qqItem3 = new AyQQComboBoxItem();
                qqItem3.ItemHeader = Directory.GetCurrentDirectory() + "/Contents/Images/login/3.jpg";
                qqItem3.NickName = "妹紫";
                qqItem3.AyNumber = "486812";
                qqItem3.Content = "486812";
                qqItem3.PrewItem = qqItem2;
                qqItem2.LastItem = qqItem3;

                AyQQComboBoxItem qqItem4 = new AyQQComboBoxItem();
                qqItem4.ItemHeader = Directory.GetCurrentDirectory() + "/Contents/Images/login/4.jpg";
                qqItem4.NickName = "胖子洋";
                qqItem4.AyNumber = "98745669";
                qqItem4.Content = "98745669";
                qqItem4.PrewItem = qqItem3;
                qqItem3.LastItem = qqItem4;
                AyQQComboBoxItem qqItem5 = new AyQQComboBoxItem();
                qqItem5.ItemHeader = Directory.GetCurrentDirectory() + "/Contents/Images/login/5.jpg";
                qqItem5.NickName = "WPF学二代床前明月光的富二代就是我没错";
                qqItem5.AyNumber = "157789547";
                qqItem5.Content = "157789547";
                qqItem5.PrewItem = qqItem4;
                qqItem4.LastItem = qqItem5;

                cbo.Items.Add(qqItem);
                cbo.Items.Add(qqItem2);
                cbo.Items.Add(qqItem3);
                cbo.Items.Add(qqItem4);
                cbo.Items.Add(qqItem5);
                cbo.deleteItem += (obj) =>
                {
                    //if (MessageBoxResult.OK == AyMessageBox.ShowDelete("确认删除本条账号信息吗", "删除"))
                    //{
                    cbo.Items.Remove(obj);
                    //}

                };
            }
        }

        private void closeWindow_LostKeyboardFocus_1(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (e.KeyboardDevice.IsKeyDown(Key.Tab))
            {
                email.Focus();
            }
        }

        private void bindemail_Loaded(object sender, RoutedEventArgs e)
        {
            if (email == null)
            {
                email = sender as AyTextBox;
            }
        }
        PopupEx keyboard;
        AyImageButton imageButtonPwd;

        private void pwdPopup_Loaded(object sender, RoutedEventArgs e)
        {
            if (keyboard == null)
            {
                keyboard = sender as PopupEx;
                keyboard.Closed += Keyboard_Closed;
            }
        }


        private void Keyboard_Closed(object sender, EventArgs e)
        {
            AyTime.setTimeout(100, () =>
            {
                openPop = false;
            });
            
            
        }

        private void btnPwdKeboard_Loaded(object sender, RoutedEventArgs e)
        {
            if (imageButtonPwd == null)
            {
                imageButtonPwd = sender as AyImageButton;
                imageButtonPwd.Click += ImageButtonPwd_Click;
                imageButtonPwd.MouseEnter += pb_MouseEnter;
            }
        }


        public bool openPop = false;
        private void ImageButtonPwd_Click(object sender, RoutedEventArgs e)
        {

            if (openPop)
            {
                keyboard.IsOpen = false;
                openPop = false;
            }
            else
            {
                keyboard.IsOpen = true;
                openPop = true;
            }
        }
        Border userB;
        Border pwdB;
        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
            if (userB == null)
            {
                userB = sender as Border;
            }
        }

        private void pwdBorder_Loaded(object sender, RoutedEventArgs e)
        {
            if (pwdB == null)
            {
                pwdB = sender as Border;
            }
        }

        private void UserName_MouseEnter(object sender, MouseEventArgs e)
        {
            if (userB != null) {
                userB.Visibility = Visibility.Visible;
                Brush userColor= this.FindResource("AyTextbox.Static.Border") as Brush;
                cbo.BorderBrush = userColor;
            }
        }

        private void UserName_MouseLeave(object sender, MouseEventArgs e)
        {
            if (userB != null)
            {
                userB.Visibility = Visibility.Collapsed;
                cbo.BorderBrush = SolidColorBrushConverter.From16JinZhi("#ABADB3") ;
            }
        }

        private void pb_MouseEnter(object sender, MouseEventArgs e)
        {
            if (pwdB != null)
            {
                pwdB.Visibility = Visibility.Visible;
            }
        }

        private void pb_MouseLeave(object sender, MouseEventArgs e)
        {
            if (pwdB != null)
            {
                pwdB.Visibility = Visibility.Collapsed;
            }
        }
        PasswordBox wpb;
        private void pb_Loaded(object sender, RoutedEventArgs e)
        {
            if (wpb == null)
            {
                wpb = sender as PasswordBox;
            }
        }
    }


    public class AyLoginFrontWindow
    {

    }
    public class AyLoginBackWindow
    {
    }

}
