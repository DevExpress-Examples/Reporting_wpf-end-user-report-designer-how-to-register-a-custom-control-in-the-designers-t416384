using DevExpress.Utils.Design;
using DevExpress.Utils.Serializing;
using DevExpress.XtraReports;
using DevExpress.XtraReports.Expressions;
using DevExpress.XtraReports.UI;
using System.ComponentModel;

namespace WpfApp_CustomNumericLabel {
    [ToolboxItem(true)]
    [ToolboxSvgImage("WpfApp_CustomNumericLabel.NumericLabel.svg, WpfApp_CustomNumericLabel")]
    [DefaultBindableProperty("Number")]
    [DisplayName("Numeric Label")]
    public class NumericLabel : XRLabel {
        [DefaultValue(0)]
        [XtraSerializableProperty]
        public int Number { get; set; }

        // Set the "Browsable" and "EditorBrowsable" attributes to "false" and "Never"
        // to hide the "Text" property from the "Properties" window and editor (IntelliSense).
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override string Text {
            get { return Number.ToString(); }
            set {
                int i;
                Number = (int.TryParse(value, out i)) ? i : 0;
            }
        }

        // Implement a static constructor as shown below to add
        // the "Number" property to the property grid's "Expressions" tab.
        static NumericLabel() {
            // Specify an array of events in which the property should be available.
            string[] eventNames = new string[] { "BeforePrint" };

            // Specify the property position in the property grid's "Expressions" tab.
            // 0 - fist, 1000 - last.
            int position = 0;

            // Specify an array of the property's inner properties.
            string[] nestedBindableProperties = null;

            // Specify the property's category in the property grid's "Expressions" tab.
            // The empty string corresponds the root category.
            string scopeName = "";

            // Create and set description for the "Number" property.
            ExpressionBindingDescription description = new ExpressionBindingDescription(
                eventNames, position, nestedBindableProperties, scopeName
            );

            ExpressionBindingDescriptor.SetPropertyDescription(
                typeof(NumericLabel), nameof(Number), description
            );
        }
    }
}
