//------------------------------------------------------------------------------
// <copyright file="MvvmWindowControl.xaml.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace MVVMProductivity
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;
    using System.ComponentModel.Design;
    using Microsoft.VisualStudio.Shell.Interop;


    /// <summary>
    /// Interaction logic for MvvmWindowControl.
    /// </summary>
    public partial class MvvmWindowControl : UserControl
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="MvvmWindowControl"/> class.
        /// </summary>
        public MvvmWindowControl()
        {
            this.InitializeComponent();
        }

        public System.Windows.Controls.MediaElement MediaPlayer
        {
            get { return mediaElement1; }
        }

        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "MvvmWindow");
        }
    }
}