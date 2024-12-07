
namespace CS311_FinalProject_MLC
{
    public partial class UnitConverter : Form
    {
        //private int cboFromUnit_SelectedIndexChanged;

        public UnitConverter()
        {
            InitializeComponent();

            //Add event handlers for radio buttons
            rdoLength.CheckedChanged += RadioButtons_CheckedChanged;
            rdoTemperature.CheckedChanged += RadioButtons_CheckedChanged;
            rdoMass.CheckedChanged += RadioButtons_CheckedChanged;

            //Add event handler for From Unit Combobox 
            //cboFromUnit.SelectedIndexChanged += cboFromUnit_SelectedIndexChanged;

            //Add event handler for the calculate button
            btnCalculate.Click += btnCalculate_Click;
        } //end UnitConverter

        //Event handler for radio buttons
        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                //Clear current items in combo box
                cboFromUnit.Items.Clear();
                cboToUnit.Items.Clear();

                //Update the combo box based on the selected radio button
                if (radioButton == rdoLength)
                {
                    cboFromUnit.Items.AddRange(new String[] { "Meter (m)", "Feet (ft)", "Kilometer (km)", "Mile (mi)" });
                    cboToUnit.Items.AddRange(new String[] { "Meter (m)", "Feet (ft)", "Kilometer (km)", "Mile (mi)" });

                }
                else if (radioButton == rdoTemperature)
                {
                    cboFromUnit.Items.AddRange(new String[] { "Celsius (C)", "Fahrenheit (F)" });
                    cboToUnit.Items.AddRange(new String[] { "Celsius (C)", "Fahrenheit (F)" });

                }
                else if (radioButton == rdoMass)
                {
                    cboFromUnit.Items.AddRange(new String[] { "Kilograms (kg)", "Pounds (lb)", "Grams (g)", "Ounces (oz)" });
                    cboToUnit.Items.AddRange(new String[] { "Kilograms (kg)", "Pounds (lb)", "Grams (g)", "Ounces (oz)" });

                }
            }
        } //end RadioButtons_CheckedChange

        //Calculate button for the conversions
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtFromMeasurement.Text, out double inputValue))
            {
                string fromUnit = cboFromUnit.SelectedItem?.ToString();
                string toUnit = cboToUnit.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(fromUnit) && !string.IsNullOrEmpty(toUnit))
                {
                    try
                    {
                        double result = PerformanceConvervsion(inputValue, fromUnit, toUnit);

                        txtToMeasurement.Text = result.ToString();
                    }
                    catch (NotSupportedException ex)
                    {
                        MessageBox.Show(ex.Message, "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please select both from and to unit measurement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //end btnCalculate_Click
        //Conversion math to go with the calculate button
        private double PerformanceConvervsion(double value, string fromUnit, string toUnit)
        {
            if (fromUnit == "Meter (m)" && toUnit == "Feet (ft)")
                return value * 3.28084;
            if (fromUnit == "Feet (ft)" && toUnit == "Meter (m)")
                return value / 3.28084;
            if (fromUnit == "Kilometer (km)" && toUnit == "Mile (mi)")
                return value * 0.621371;
            if (fromUnit == "Mile (mi)" && toUnit == "Kilometer (km)")
                return value / 0.621371;
            if (fromUnit == "Celsius (C)" && toUnit == "Fahrenheit (F)")
                return (value * 9 / 5) + 32;
            if (fromUnit == "Fahrenheit (F)" && toUnit == "Celsius(C)")
                return (value - 32) * 5 / 9;
            if (fromUnit == "Kilograms (kg)" && toUnit == "Pounds (lb)")
                return value * 2.20462;
            if (fromUnit == "Pounds (lb)" && toUnit == "Kilograms (kg)")
                return value / 2.20462;
            if (fromUnit == "Grams (g)" && toUnit == "Ounces (oz)")
                return value * 0.035274;
            if (fromUnit == "Ounces (oz)" && toUnit == "Grams (g)")
                return value / 0.035274;

            //Throw an exception if the option picked is not supported (has no formula for the conversion
            throw new NotSupportedException($"Conversion from {fromUnit} to {toUnit} is not supported. Please review the supported conversions");
        } //end PerformanceConversion

        //Reset Button
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clear the input for textboxes
            txtFromMeasurement.Clear();
            txtToMeasurement.Clear();

            //Reset the combo box:
            cboFromUnit.SelectedIndex = -1;
            cboToUnit.SelectedIndex = -1;

            //Reset radio buttons
            rdoLength.Checked = false;
            rdoTemperature.Checked = false;
            // rdoMass.Checked = false;
        } //end btnReset_Click

        //Provide directions on how to use the converter
        private void btnDirections_Click(object sender, EventArgs e)
        {
            string directions = "To use the unit converter:\n\n" +
                "1.) Select a converstion category (Length, Temperature, or Mass/Weight) from the Conversion Menu.\n" +
                "2.) Choose the starting unit and the unit to convert to using the dropdown boxes.\n" +
                "3.) Enter the value you want to convert in the input box.\n" +
                "4.) Click 'Calculate' to see the results.\n" +
                "5.) Use 'Reset' to clear the form and start over.\n\n" +
                "Note: Please see the supported conversion types to see what conversions are supported by this converter.";

            MessageBox.Show(directions, "Directions", MessageBoxButtons.OK, MessageBoxIcon.Information);

        } //end btnDirections_Click

        //Show supported conversions by the calculator
        private void btnConversions_Click(object sender, EventArgs e)
        {
            string conversions = "The supported conersions are: \n\n" +
                "Length:\n" +
                "Meters to Feet\n" +
                "Feet to Meters\n" +
                "Kilometers to Miles\n" +
                "Miles to Kilometers\n\n" +
                "Temperature: \n" +
                "Celsius to Fahrenheit\n" +
                "Fahrenheit to Celsius\n\n" +
                "Weight/Mass\n" +
                "Kilograms to Pounds\n" +
                "Pounds to Kilograms\n" +
                "Grams to Ounces\n" +
                "Ounces to Grams";

            MessageBox.Show(conversions, "Supported Conversions", MessageBoxButtons.OK, MessageBoxIcon.Information);

        } //end btnConversions_Click
    } //end partial class
} //end namespace
