using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEtoKSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Convert_Click(object sender, EventArgs e)
        {
            string se_code = se.Text;

            string scaledspace_color_path = scaledSpaceTexturePath.Text;
            string scaledspace_normal_path = scaledSpaceNormalPath.Text;
            string colormap_path = colormapPath.Text;
            string heightmap_path = heightmapPath.Text;

            ksp.Text = "@Kopernicus:AFTER[Kopernicus] {" + se_code
                .Replace("Planet	\"", "Body" + Environment.NewLine + "{" + Environment.NewLine + "   name = ")
                .Replace("ParentBody     \"", "@Orbit" + Environment.NewLine + "{" + Environment.NewLine + "@referenceBody = ")
                .Replace("Class	       \"Desert\"", "}" + Environment.NewLine + "Template" + Environment.NewLine + "{" + Environment.NewLine + "   name = Duna" + Environment.NewLine + "   removeAllPQSMods = true" + Environment.NewLine + "}" + Environment.NewLine + "Properties" + Environment.NewLine + "{")
                .Replace("Class	       \"Selena\"", "}" + Environment.NewLine + "Template" + Environment.NewLine + "{" + Environment.NewLine + "   name = Tylo" + Environment.NewLine + "   removeAllPQSMods = true" + Environment.NewLine + "}" + Environment.NewLine + "Properties" + Environment.NewLine + "{")
                .Replace("Class	       \"Terra\"", "}" + Environment.NewLine + "Template" + Environment.NewLine + "{" + Environment.NewLine + "   name = Kerbin" + Environment.NewLine + "   removeAllPQSMods = true" + Environment.NewLine + "}" + Environment.NewLine + "Properties" + Environment.NewLine + "{")
                .Replace("Class	       \"Oceania\"", "}" + Environment.NewLine + "Template" + Environment.NewLine + "{" + Environment.NewLine + "   name = Laythe" + Environment.NewLine + "   removeAllPQSMods = true" + Environment.NewLine + "}" + Environment.NewLine + "Properties" + Environment.NewLine + "{")
                .Replace("Class	       \"Titan\"", "}" + Environment.NewLine + "Template" + Environment.NewLine + "{" + Environment.NewLine + "   name = Laythe" + Environment.NewLine + "   removeAllPQSMods = true" + Environment.NewLine + "}" + Environment.NewLine + "Properties" + Environment.NewLine + "{")
                .Replace("Class	       \"IceWorld\"", "}" + Environment.NewLine + "Template" + Environment.NewLine + "{" + Environment.NewLine + "   name = Eeloo" + Environment.NewLine + "   removeAllPQSMods = true" + Environment.NewLine + "}" + Environment.NewLine + "Properties" + Environment.NewLine + "{")
                .Replace("Class	       \"GasGiant\"", "}" + Environment.NewLine + "Template" + Environment.NewLine + "{" + Environment.NewLine + "   name = Jool" + Environment.NewLine + "}" + Environment.NewLine + "Properties" + Environment.NewLine + "{")
                .Replace("Class	       \"IceGiant\"", "}" + Environment.NewLine + "Template" + Environment.NewLine + "{" + Environment.NewLine + "   name = Jool" + Environment.NewLine + "}" + Environment.NewLine + "Properties" + Environment.NewLine + "{")
                .Replace("Radius          ", "Properties" + Environment.NewLine + "" + Environment.NewLine + "  radius = 100" + Environment.NewLine + "  @radius *= ")
                .Replace("Mass            ", "  mass = 5.29157926281091E+22" + Environment.NewLine + "  @mass *= ")
                .Replace("InertiaMoment", " /* InertiaMoment ")
                .Replace("RotationPeriod  ", " */ " + Environment.NewLine + "rotation" + "Period = 900" + Environment.NewLine + "@" + "rotation" + "Period *= ")
                .Replace("Obliquity       ", "/* Obliquity")
                .Replace("Orbit", "	Orbit")
                .Replace("	RefPlane", "	// RefPlane")
                .Replace("SemiMajorAxis   ", "semiMajorAxis = 14959787070" + Environment.NewLine + "        @semiMajorAxis *= ")
                .Replace("Period", "// Period")
                .Replace("Eccentricity    ", "eccentricity = ")
                .Replace("Inclination     ", "inclination = ")
                .Replace("AscendingNode   ", "longitudeOfAscendingNode = ")
                .Replace("ArgOfPericenter ", "argumentOfPeriapsis = ")
                .Replace("MeanAnomaly     ", "meanAnomalyAtEpoch = 0.01745329251" + Environment.NewLine + "        @meanAnomalyAtEpoch *= ")
                .Replace("rotation// ", "rotation") + "	ScaledVersion" + Environment.NewLine + "    {" + Environment.NewLine + "		Material" + Environment.NewLine + "        {" + Environment.NewLine + "            // Common scaled space settings" + Environment.NewLine + "            texture = " + scaledspace_color_path + Environment.NewLine + "            normals = " + scaledspace_normal_path + Environment.NewLine + "		}" + Environment.NewLine + "    }" + Environment.NewLine + "	PQS" + Environment.NewLine + "        {" + Environment.NewLine + "            maxQuadLengthsPerFrame = 0.03" + Environment.NewLine + "            minLevel = 2" + Environment.NewLine + "            maxLevel = 12" + Environment.NewLine + "            minDetailDistance = 8" + Environment.NewLine + "            Mods" + Environment.NewLine + "            {" + Environment.NewLine + "                VertexColorMap" + Environment.NewLine + "                {" + Environment.NewLine + "                    map = " + colormap_path + Environment.NewLine + "                    order = 500" + Environment.NewLine + "                    enabled = true" + Environment.NewLine + "                }" + Environment.NewLine + "                VertexHeightMap" + Environment.NewLine + "                {" + Environment.NewLine + "                    map = " + heightmap_path + Environment.NewLine + "                    offset = -1000.0" + Environment.NewLine + "                    deformity = 10000.0" + Environment.NewLine + "                    scaleDeformityByRadius = false" + Environment.NewLine + "                    order = 20" + Environment.NewLine + "                    enabled = true" + Environment.NewLine + "                }" + Environment.NewLine + "		}" + Environment.NewLine + "	}" + Environment.NewLine + Environment.NewLine + "}" + Environment.NewLine + "}";
        }
    }
}
