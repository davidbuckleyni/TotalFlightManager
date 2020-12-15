using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Microsoft.FlightSimulator.SimConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using System.Windows.Forms;
using Telerik.WinControls.UI;
 

namespace TotalFlightManager
{
    public partial class frmMain : RadRibbonForm
    {
        GMapOverlay gMapOverlay = new GMapOverlay();

        private string output;
        private int response;
        private const int WM_USER_SIMCONNECT = 0x402;
        private enum DATA_REQUESTS
        {
            REQUEST_1
        }

        private enum DEFINITIONS
        {
            Struct1
        }

        private Microsoft.FlightSimulator.SimConnect.SimConnect my_simconnect;
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct Struct1
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x100)]
            public string title;
            public double latitude;
            public double longitude;
            public double trueheading;
            public double groundaltitude;
        }

        public frmMain()
        {
            InitializeComponent();
            
                gMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.Zoom = 5;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void radRibbonBarGroup1_Click(object sender, EventArgs e)
        {

        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }
        public void Connect()
        {
            if (my_simconnect == null)
            {
                try
                {
                    my_simconnect = new Microsoft.FlightSimulator.SimConnect.SimConnect("Managed Data Request", base.Handle, 0x402, null, 0);
                    initDataRequest();
                    label_status.Text = "Connected";
                    timer1.Enabled = true;

                }
                catch (COMException)
                {

                }
            }
            else
            {
                label_status.Text = "Error - try again";
                closeConnection();

                timer1.Enabled = false;
            }


        }

        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == 0x402)
            {
                if (my_simconnect != null)
                {
                    my_simconnect.ReceiveMessage();
                }
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }

        private void closeConnection()
        {
            if (my_simconnect != null)
            {
                my_simconnect.Dispose();
                my_simconnect = null;
                label_status.Text = "Connection closed";
            }
        }
        private void simconnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {
            label_status.Text = "Exception received: " + ((uint)data.dwException);
        }

        private void simconnect_OnRecvOpen(SimConnect sender, SIMCONNECT_RECV_OPEN data)
        {
            label_status.Text = "Connected to sim";
        }
        private void simconnect_OnRecvSimobjectDataBytype(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
        {
            string DirNumberText = "";
            string DirNumber1Text = "";
            string DirNumber2Text = "";
            string FileNumberText = "";
            string FileNumber1Text = "";
            string FileNumber2Text = "";
            double DirNumber1 = 0;
            double DirNumber2 = 0;
            double FileNumber1 = 0;
            double FileNumber2 = 0;


            if (data.dwRequestID == 0)
            {
                Struct1 struct1 = (Struct1)data.dwData[0];
                // label_aircraft.Text = struct1.title.ToString();
                textBox_latitude.Text = struct1.latitude.ToString();
                textBox_longitude.Text = struct1.longitude.ToString();
                textBox_trueheading.Text = struct1.trueheading.ToString();
                textBox_groundaltitude.Text = struct1.groundaltitude.ToString();
                var latitude = struct1.latitude;
                var longitude = struct1.longitude;
                gMapControl1.Position = new PointLatLng(latitude, longitude) ;
                gMapControl1.Zoom = 20;
                gMapControl1.MinZoom = 3;
                gMapControl1.MaxZoom = 15;
                gMapControl1.ShowCenter = false;

                PointLatLng point = new PointLatLng(latitude, longitude);

                 GMapMarker marker = new GMarkerGoogle(new PointLatLng(latitude, longitude), new Bitmap(AirManagerResources.aircraft_jet_user));

                gMapOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(gMapOverlay);   // overlay added
              


                DirNumber1 = ((int)(((180.0 + (struct1.longitude)) * 12) / 360.0));
                if (DirNumber1 < 10)
                    DirNumber1Text = "0" + DirNumber1.ToString();
                else
                    DirNumber1Text = DirNumber1.ToString();
                DirNumber2 = ((int)(((90.0 - (struct1.latitude)) * 8) / 180.0));
                if (DirNumber2 < 10)
                    DirNumber2Text = "0" + DirNumber2.ToString();
                else
                    DirNumber2Text = DirNumber2.ToString();
                DirNumberText = DirNumber1Text + DirNumber2Text;

                FileNumber1 = ((int)(((180.0 + (struct1.longitude)) * 96) / 360.0));
                if (FileNumber1 < 10)
                    FileNumber1Text = "0" + FileNumber1.ToString();
                else
                    FileNumber1Text = FileNumber1.ToString();
                FileNumber2 = ((int)(((90.0 - (struct1.latitude)) * 64) / 180.0));
                if (FileNumber2 < 10)
                    FileNumber2Text = "0" + FileNumber2.ToString();
                else
                    FileNumber2Text = FileNumber2.ToString();
                FileNumberText = FileNumber1Text + FileNumber2Text;

              

            }
            else
            {
                label_status.Text = "Unknown request ID: " + ((uint)data.dwRequestID);
                textBox_latitude.Text = "";
                textBox_longitude.Text = "";
                textBox_trueheading.Text = "";
                textBox_groundaltitude.Text = "";
              }
        }
        private void simconnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            label_status.Text = "sim has exited";
            closeConnection();
            timer1.Enabled = false;
        }
        private void initDataRequest()
        {
            try
            {
                my_simconnect.OnRecvOpen += new SimConnect.RecvOpenEventHandler(simconnect_OnRecvOpen);
                my_simconnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(simconnect_OnRecvQuit);
                my_simconnect.OnRecvException += new SimConnect.RecvExceptionEventHandler(simconnect_OnRecvException);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Title", null, SIMCONNECT_DATATYPE.STRING256, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Latitude", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Longitude", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Plane Heading Degrees True", "degrees", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                my_simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "Ground Altitude", "meters", SIMCONNECT_DATATYPE.FLOAT64, 0.0f, SimConnect.SIMCONNECT_UNUSED);


                my_simconnect.RegisterDataDefineStruct<Struct1>(DEFINITIONS.Struct1);
                my_simconnect.OnRecvSimobjectDataBytype += new SimConnect.RecvSimobjectDataBytypeEventHandler(simconnect_OnRecvSimobjectDataBytype);
            }
            catch (COMException exception1)
            {
                displayText(exception1.Message);
            }
        }
        private void displayText(string s)
        {
            output = output.Substring(output.IndexOf("\n") + 1);
            object obj1 = output;
            output = string.Concat(new object[] { obj1, "\n", response++, ": ", s });
            label_status.Text = output;
        }
        private void radRibbonBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_trueheading_TextChanged(object sender, EventArgs e)
        {

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            my_simconnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_1, DEFINITIONS.Struct1, 0, SIMCONNECT_SIMOBJECT_TYPE.USER);
            label_status.Text = "Request sent...";
        }
    }
}
