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
     

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string Proprety = "#region Property " + PropName.Text + "\nprivate " + PropType.Text + " _" + PropName.Text + ";\npublic " + PropType.Text + " _" + PropName.Text + "\n {\n get\n { \nreturn _" + PropName.Text + ";\n}\n set\n {\n _" + PropName.Text + " = value;\n RaisePropertyChanged(" + PropName.Text + ");\n  }\n }\n#endregion";

            System.Windows.Forms.Clipboard.SetText(Proprety);
        }

    private void buttonIcomm_Click(object sender, RoutedEventArgs e)
        {
            string IComm = "#region ICommand "+ IComName.Text +"\n" +
                        "private ICommand _"+ IComName.Text.ToLower() +";\n\n" +
                        "public ICommand "+ IComName.Text +"\n"+
                        " {\n" +
                        "    get\n" +
                        "    {\n" +
                        "        if (_"+ IComName.Text.ToLower() +" == null)\n" +
                        "        {\n" +
                        "            _"+ IComName.Text.ToLower() + " = new DelegateCommand("+ IComName.Text +"Execute); // RelayCommand\n" +
                        "        }\n" +
                        "        return _" + IComName.Text.ToLower() + ";\n" +
                        "    }\n" +
                        "}\n\n" +
                        "private void " + IComName.Text + "Execute()\n" +
                        "{\n" +
                        "    Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;\n" +
                        "    try\n" +
                        "    {\n" +
                        "        /*\n" +
                        "            *****\n" +
                        "        */\n" +
                        "    }\n" +
                        "    catch (Exception ex)\n" +
                        "    {\n" +
                        "        //whatever\n" +
                        "    }\n" +
                        "    Mouse.OverrideCursor = System.Windows.Input.Cursors.Arrow;\n" +
                        "}\n" +
                        "#endregion\n";

            System.Windows.Forms.Clipboard.SetText(IComm);

        }

    private void buttonObsColl_Click(object sender, RoutedEventArgs e)
        {
            string obsColl =
                        " #region ObservableCollection "+IComName.Text+"\n"+
                        "private ObservableCollection<int> _" + IComName.Text.ToLower() + ";\n\n" +
                        "public ObservableCollection<int> " + IComName.Text + "\n" +
                        "{\n"+
                        "    get\n"+
                        "    {\n"+
                        "        return _" + IComName.Text.ToLower() + ";\n" +
                        "    }\n"+
                        "    set\n"+
                        "    {\n"+
                        "        _" + IComName.Text.ToLower() + " = value;\n" +
                        "        RaisePropertyChanged("+IComName.Text+");\n" +
                        "    }\n" +
                        "}\n" +
                        "#endregion\n";

            System.Windows.Forms.Clipboard.SetText(obsColl);
        }

    private void buttonSingle_Click(object sender, RoutedEventArgs e)
        {
            string Single =
                            "public class "+SingleName.Text+"\n" +
                            "{\n" +
                            "private " + SingleName.Text + "() { }\n\n" +

                            "private static " + SingleName.Text + " _instance = null;\n\n" +

                            "public static " + SingleName.Text + " getInstance()\n" +
                            "{\n\n" +
                            "    if (_instance == null)\n" +
                            "    {\n" +
                            "        _instance = new " + SingleName.Text + "();\n" +
                            "    }\n" +
                            "    return _instance;\n" +
                            "}\n\n" +

                            "/****/\n\n" +

                            "}\n";
            System.Windows.Forms.Clipboard.SetText(Single);
        }

        private void buttonPocoProp_Click(object sender, RoutedEventArgs e)
        {

            string PocoProprety = "public virtual "+PocoPropType.Text+" "+PocoPropName.Text+" { get; set; }\n\n" +
        "/// <summary>\n" +
        "/// functions called when properties " + PocoPropName.Text + " is changed/changing\n" +
        "/// </summary>\n\n" +
        "protected void On" + PocoPropName.Text + "Changed(" + PocoPropType.Text + " oldValue) // before proprety change\n" +
        " {\n" +
        "   //whatever you need\n" +
        " }\n\n" +
        "protected void On" + PocoPropName.Text + "Changing(" + PocoPropType.Text + " newValue) // after proprety change\n" +
        " {\n" +
        "   //whatever you need\n"+
        " }\n";

            System.Windows.Forms.Clipboard.SetText(PocoProprety);

        }
    }
}