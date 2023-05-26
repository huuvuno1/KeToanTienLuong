using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeToanTienLuong.hethongform
{
    public partial class SaoLuuForm : UserControl
    {
        public SaoLuuForm()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new Server object
                Server server = new Server("localhost"); // Replace "YourServerName" with the actual SQL Server instance name

                // Create a new Backup object
                Backup backup = new Backup() {
                    Action = BackupActionType.Database,
                    Database = "localhost", // Replace "YourDatabaseName" with the actual database name
                    BackupSetDescription = "YourBackupDescription", // Replace "YourBackupDescription" with a description for your backup
                    BackupSetName = "VuBackupName", // Replace "YourBackupName" with the desired name for your backup file
                    Initialize = true
                };

                // Set the backup file location
                BackupDeviceItem backupDevice = new BackupDeviceItem("C:\\Users\\s2huu\\OneDrive\\Documents\\YourBackupFile.bak", DeviceType.File); // Replace "YourBackupPath" and "YourBackupFile" with the desired file path and name

                // Add the backup device to the backup object
                backup.Devices.Add(backupDevice);

                // Perform the backup
                backup.SqlBackup(server);

                MessageBox.Show("Backup completed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }
    }
}
