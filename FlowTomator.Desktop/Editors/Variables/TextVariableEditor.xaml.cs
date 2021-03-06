﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace FlowTomator.Desktop
{
    public partial class TextVariableEditor : UserControl
    {
        public TextVariableEditor()
        {
            InitializeComponent();
        }

        private void TextVariableEditor_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue)
            {
                Dispatcher.BeginInvoke(new System.Action(() =>
                {
                    TextBox.SelectAll();
                    FocusManager.SetFocusedElement(this, TextBox);
                }), DispatcherPriority.ApplicationIdle);
            }
            else
            {
                FocusManager.SetFocusedElement(this, this);
            }
        }
    }
}