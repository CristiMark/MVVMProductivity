//------------------------------------------------------------------------------
// <copyright file="ToolWindow1Control.xaml.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace MVVMProd
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for ToolWindow1Control.
    /// </summary>
    public partial class ToolWindow1Control : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolWindow1Control"/> class.
        /// </summary>
        public ToolWindow1Control()
        {
            this.InitializeComponent();
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
                "ToolWindow1");
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string Proprety = "#region Property " + PropName.Text + "\nprivate " + PropType.Text + " _" + PropName.Text + ";\npublic " + PropType.Text + " _" + PropName.Text + "\n{\nget\n{\nreturn _" + PropName.Text + ";\n}\nset\n{\n_" + PropName.Text + " = value;\nRaisePropertyChanged(" + PropName.Text + ");\n}\n}\n#endregion";
            System.Windows.Forms.MessageBox.Show(Proprety);
        }

    private void buttonIcomm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonObsColl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonSingle_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}