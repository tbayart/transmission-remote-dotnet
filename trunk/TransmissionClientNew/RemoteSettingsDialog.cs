// transmission-remote-dotnet
// http://code.google.com/p/transmission-remote-dotnet/
// Copyright (C) 2009 Alan F
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jayrock.Json;

namespace TransmissionRemoteDotnet
{
    public partial class RemoteSettingsDialog : Form
    {
        private static RemoteSettingsDialog instance = null;
        private static readonly object padlock = new object();

        public static RemoteSettingsDialog Instance
        {
            get
            {
                lock (padlock)
                {
                    if (!IsActive())
                    {
                        instance = new RemoteSettingsDialog();
                    }
                }
                return instance;
            }
        }

        private static bool IsActive()
        {
            return instance != null && !instance.IsDisposed;
        }

        public static void CloseIfOpen()
        {
            if (IsActive())
                instance.Close();
        }

        public static void PortTestReplyArrived()
        {
            if (IsActive())
            {
                instance.testPortButton.Text = (string)instance.testPortButton.Tag;
                instance.testPortButton.Enabled = true;
            }
        }

        private RemoteSettingsDialog()
        {
            InitializeComponent();
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoteSettingsDialog_Load(object sender, EventArgs e)
        {
            try
            {
                JsonObject session = (JsonObject)Program.DaemonDescriptor.SessionData;
                downloadToField.Text = (string)session["download-dir"];
                limitDownloadValue.Enabled = limitDownloadCheckBox.Checked = Toolbox.ToBool(session[ProtocolConstants.FIELD_SPEEDLIMITDOWNENABLED]);
                SetLimitField(Toolbox.ToInt(session[ProtocolConstants.FIELD_SPEEDLIMITDOWN]), limitDownloadValue);
                limitUploadValue.Enabled = limitUploadCheckBox.Checked = Toolbox.ToBool(session[ProtocolConstants.FIELD_SPEEDLIMITUPENABLED]);
                SetLimitField(Toolbox.ToInt(session[ProtocolConstants.FIELD_SPEEDLIMITUP]), limitUploadValue);
                if (session.Contains("port"))
                {
                    incomingPortValue.Tag = "port";
                    incomingPortValue.Value = Toolbox.ToInt(session["port"]);
                }
                else if (session.Contains("peer-port"))
                {
                    incomingPortValue.Tag = "peer-port";
                    incomingPortValue.Value = Toolbox.ToInt(session["peer-port"]);
                }
                portForwardCheckBox.Checked = Toolbox.ToBool(session["port-forwarding-enabled"]);
                string enc = session["encryption"] as string;
                if (enc.Equals("preferred"))
                {
                    encryptionCombobox.SelectedIndex = 1;
                }
                else if (enc.Equals("required"))
                {
                    encryptionCombobox.SelectedIndex = 2;
                }
                else
                {
                    encryptionCombobox.SelectedIndex = 0;
                }
                // peer limit
                if (session.Contains(ProtocolConstants.FIELD_PEERLIMIT))
                {
                    peerLimitValue.Value = Toolbox.ToInt(session[ProtocolConstants.FIELD_PEERLIMIT]);
                    peerLimitValue.Tag = ProtocolConstants.FIELD_PEERLIMIT;
                }
                else if (session.Contains(ProtocolConstants.FIELD_PEERLIMITGLOBAL))
                {
                    peerLimitValue.Value = Toolbox.ToInt(session[ProtocolConstants.FIELD_PEERLIMITGLOBAL]);
                    peerLimitValue.Tag = ProtocolConstants.FIELD_PEERLIMITGLOBAL;
                }
                // pex
                if (session.Contains(ProtocolConstants.FIELD_PEXALLOWED))
                {
                    PEXcheckBox.Checked = Toolbox.ToBool(session[ProtocolConstants.FIELD_PEXALLOWED]);
                    PEXcheckBox.Tag = ProtocolConstants.FIELD_PEXALLOWED;
                }
                else if (session.Contains(ProtocolConstants.FIELD_PEXENABLED))
                {
                    PEXcheckBox.Checked = Toolbox.ToBool(session[ProtocolConstants.FIELD_PEXENABLED]);
                    PEXcheckBox.Tag = ProtocolConstants.FIELD_PEXENABLED;
                }
                // blocklist
                if (updateBlocklistButton.Enabled = blocklistEnabledCheckBox.Enabled = session.Contains(ProtocolConstants.FIELD_BLOCKLISTENABLED))
                {
                    blocklistEnabledCheckBox.Checked = Toolbox.ToBool(session[ProtocolConstants.FIELD_BLOCKLISTENABLED]);
                }
                if (altSpeedLimitEnable.Enabled =
                    altUploadLimitField.Enabled =
                    altDownloadLimitField.Enabled =
                    altTimeConstraintEnabled.Enabled =
                    timeConstraintEndHours.Enabled =
                    timeConstraintBeginHours.Enabled =
                    timeConstaintEndMinutes.Enabled =
                    timeConstaintBeginMinutes.Enabled =
                    session.Contains(ProtocolConstants.FIELD_ALTSPEEDENABLED))
                {
                    int altDown = Toolbox.ToInt(session[ProtocolConstants.FIELD_ALTSPEEDDOWN]);
                    altDownloadLimitField.Value = altDown <= altDownloadLimitField.Maximum ? altDown : 0;
                    int altUp = Toolbox.ToInt(session[ProtocolConstants.FIELD_ALTSPEEDUP]);
                    altUploadLimitField.Value = altUp <= altUploadLimitField.Maximum ? altUp : 0;
                    altDownloadLimitField.Enabled = altUploadLimitField.Enabled = altSpeedLimitEnable.Checked = Toolbox.ToBool(session[ProtocolConstants.FIELD_ALTSPEEDENABLED]);
                    timeConstaintBeginMinutes.Enabled = timeConstaintEndMinutes.Enabled = timeConstraintBeginHours.Enabled = timeConstraintEndHours.Enabled = altTimeConstraintEnabled.Checked = Toolbox.ToBool(session["alt-speed-time-enabled"]);
                    int altSpeedTimeBegin = Toolbox.ToInt(session[ProtocolConstants.FIELD_ALTSPEEDTIMEBEGIN]);
                    int altSpeedTimeEnd = Toolbox.ToInt(session[ProtocolConstants.FIELD_ALTSPEEDTIMEEND]);
                    timeConstraintBeginHours.Value = Math.Floor((decimal)altSpeedTimeBegin / 60);
                    timeConstraintEndHours.Value = Math.Floor((decimal)altSpeedTimeEnd / 60);
                    timeConstaintBeginMinutes.Value = altSpeedTimeBegin % 60;
                    timeConstaintEndMinutes.Value = altSpeedTimeEnd % 60;
                }
                if (seedRatioEnabledCheckBox.Enabled = seedLimitUpDown.Enabled = session.Contains(ProtocolConstants.FIELD_SEEDRATIOLIMITED))
                {
                    seedLimitUpDown.Value = Toolbox.ToDecimal(session[ProtocolConstants.FIELD_SEEDRATIOLIMIT]);
                    seedRatioEnabledCheckBox.Checked = Toolbox.ToBool(session[ProtocolConstants.FIELD_SEEDRATIOLIMITED]);
                }
                if (dhtEnabled.Enabled = session.Contains(ProtocolConstants.FIELD_DHTENABLED))
                {
                    dhtEnabled.Checked = Toolbox.ToBool(session[ProtocolConstants.FIELD_DHTENABLED]);
                }
                testPortButton.Enabled = Program.DaemonDescriptor.RpcVersion >= 5;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to load settings data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void SetLimitField(int limit, NumericUpDown field)
        {
            if (Program.DaemonDescriptor.Version < 1.40)
            {
                field.Value = limit >= 1024 && limit <= field.Maximum ? limit / 1024 : 0;
            }
            else
            {
                field.Value = limit >= 0 && limit <= field.Maximum ? limit : 0;
            }
        }

        private void LimitUploadCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            limitUploadValue.Enabled = limitUploadCheckBox.Checked;
        }

        private void LimitDownloadCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            limitDownloadValue.Enabled = limitDownloadCheckBox.Checked;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            JsonObject request = Requests.CreateBasicObject(ProtocolConstants.METHOD_SESSIONSET);
            JsonObject arguments = Requests.GetArgObject(request);
            arguments.Put((string)incomingPortValue.Tag, incomingPortValue.Value);
            arguments.Put(ProtocolConstants.FIELD_PORTFORWARDINGENABLED, portForwardCheckBox.Checked);
            arguments.Put((string)PEXcheckBox.Tag, PEXcheckBox.Checked);
            arguments.Put((string)peerLimitValue.Tag, peerLimitValue.Value);
            switch (encryptionCombobox.SelectedIndex)
            {
                case 1:
                    arguments.Put(ProtocolConstants.FIELD_ENCRYPTION, ProtocolConstants.VALUE_PREFERRED);
                    break;
                case 2:
                    arguments.Put(ProtocolConstants.FIELD_ENCRYPTION, ProtocolConstants.VALUE_REQUIRED);
                    break;
                default:
                    arguments.Put(ProtocolConstants.FIELD_ENCRYPTION, ProtocolConstants.VALUE_TOLERATED);
                    break;
            }
            arguments.Put(ProtocolConstants.FIELD_SPEEDLIMITUPENABLED, limitUploadCheckBox.Checked);
            arguments.Put(ProtocolConstants.FIELD_SPEEDLIMITUP, limitUploadValue.Value);
            arguments.Put(ProtocolConstants.FIELD_SPEEDLIMITDOWNENABLED, limitDownloadCheckBox.Checked);
            arguments.Put(ProtocolConstants.FIELD_SPEEDLIMITDOWN, limitDownloadValue.Value);
            if (altSpeedLimitEnable.Enabled)
            {
                arguments.Put(ProtocolConstants.FIELD_ALTSPEEDENABLED, altSpeedLimitEnable.Checked);
                arguments.Put(ProtocolConstants.FIELD_ALTSPEEDDOWN, altDownloadLimitField.Value);
                arguments.Put(ProtocolConstants.FIELD_ALTSPEEDUP, altUploadLimitField.Value);
            }
            if (altTimeConstraintEnabled.Enabled)
            {
                arguments.Put(ProtocolConstants.FIELD_ALTSPEEDTIMEENABLED, altTimeConstraintEnabled.Checked);
                arguments.Put(ProtocolConstants.FIELD_ALTSPEEDTIMEBEGIN, timeConstraintBeginHours.Value*60+timeConstaintBeginMinutes.Value);
                arguments.Put(ProtocolConstants.FIELD_ALTSPEEDTIMEEND, timeConstraintEndHours.Value*60+timeConstaintEndMinutes.Value);
            }
            if (blocklistEnabledCheckBox.Enabled)
            {
                arguments.Put(ProtocolConstants.FIELD_BLOCKLISTENABLED, blocklistEnabledCheckBox.Checked);
            }
            if (seedRatioEnabledCheckBox.Enabled)
            {
                arguments.Put(ProtocolConstants.FIELD_SEEDRATIOLIMITED, seedRatioEnabledCheckBox.Checked);
                arguments.Put(ProtocolConstants.FIELD_SEEDRATIOLIMIT, seedLimitUpDown.Value);
            }
            if (dhtEnabled.Enabled)
            {
                arguments.Put(ProtocolConstants.FIELD_DHTENABLED, dhtEnabled.Checked);
            }
            arguments.Put(ProtocolConstants.FIELD_DOWNLOADDIR, downloadToField.Text);
            SettingsWorker.RunWorkerAsync(request);
            this.Close();
        }

        private void SettingsWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = CommandFactory.Request((JsonObject)e.Argument);
        }

        private void SettingsWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ICommand command = (ICommand)e.Result;
            command.Execute();
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            t.Stop();
            Program.Form.CreateActionWorker().RunWorkerAsync(Requests.SessionGet());
        }

        private void altSpeedLimitEnable_CheckedChanged(object sender, EventArgs e)
        {
            altUploadLimitField.Enabled = altDownloadLimitField.Enabled = altSpeedLimitEnable.Checked;
        }

        private void altTimeConstraintEnabled_CheckedChanged(object sender, EventArgs e)
        { 
            timeConstaintBeginMinutes.Enabled = timeConstaintEndMinutes.Enabled = timeConstraintBeginHours.Enabled = timeConstraintEndHours.Enabled = altTimeConstraintEnabled.Checked;
        }

        private void blocklistEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            updateBlocklistButton.Enabled = blocklistEnabledCheckBox.Checked;
        }

        private void updateBlocklistButton_Click(object sender, EventArgs e)
        {
            updateBlocklistButton.Enabled = false;
            updateBlocklistButton.Tag = updateBlocklistButton.Text;
            updateBlocklistButton.Text = OtherStrings.Updating;
            Program.Form.CreateActionWorker().RunWorkerAsync(Requests.BlocklistUpdate());
        }

        public static void BlocklistUpdateDone(int size)
        {
            if (IsActive())
            {
                instance.updateBlocklistButton.Enabled = true;
                instance.updateBlocklistButton.Text = (string)instance.updateBlocklistButton.Tag;
                instance.label15.Text = String.Format(OtherStrings.XInBlocklist, size);
            }
        }

        private void seedRatioEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            seedLimitUpDown.Enabled = seedRatioEnabledCheckBox.Checked;
        }

        private void testPortButton_Click(object sender, EventArgs e)
        {
            testPortButton.Enabled = false;
            testPortButton.Tag = testPortButton.Text;
            testPortButton.Text = OtherStrings.Querying;
            Program.Form.CreateActionWorker().RunWorkerAsync(Requests.PortTest());
        }
    }
}
