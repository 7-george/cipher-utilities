using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace Cipher_Utilities.MVVM.View
{
    public partial class NvDriverStripperView : UserControl
    {
        public NvDriverStripperView()
        {
            InitializeComponent();
        }

        //Launch DDU
        private void dduDownloadLink_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string _filePath = System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            Process Launch = new Process();
            Launch.StartInfo.FileName = _filePath + "/Library/Bin/DDU.exe";
            Launch.StartInfo.UseShellExecute = true;
            Launch.StartInfo.Verb = "runas";
            Launch.Start();
        }

        //Method
        private void readyButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Directory.Exists(@"C:\driver"))
            {
                if (Directory.Exists(@"C:\driver\NVI2"))
                {
                    if (Directory.Exists(@"C:\driver\Display.Driver"))
                    {
                        if (Directory.Exists(@"C:\driver\GFExperience"))
                        {
                            if (File.Exists(@"C:\driver\EULA.txt"))
                            {
                                if (File.Exists(@"C:\driver\ListDevices.txt"))
                                {
                                    if (File.Exists(@"C:\driver\setup.cfg"))
                                    {
                                        //Original File Count
                                        DirectoryInfo originalDir = new DirectoryInfo(@"C:\driver");
                                        int originalFileCount = originalDir.GetFiles().Length;

                                        //Validation
                                        validationText.Text = "Valid driver folder found - all tests passed!";
                                        
                                        //GFExperience Directory File Cleanup
                                        string[] filePaths = Directory.GetFiles(@"C:\driver\GFExperience");
                                        foreach (string filePath in filePaths)
                                        {
                                            string name = new FileInfo(filePath).Name;
                                            if (!name.Contains("FunctionalConsent"))
                                            {
                                                if (!name.Contains("EULA"))
                                                {
                                                    if (!name.Contains("license"))
                                                    {
                                                        File.Delete(filePath);
                                                    }
                                                }
                                            }
                                        }

                                        //GFExperience Directory Folder Cleanup
                                        string[] GFEfolderPaths = Directory.GetDirectories(@"C:\driver\GFExperience");
                                        foreach (string GFEfolderPath in GFEfolderPaths)
                                        {
                                            string GFEname = new DirectoryInfo(GFEfolderPath).Name;

                                            if (!GFEname.Contains("PrivacyPolicy"))
                                            {
                                                Directory.Delete(GFEfolderPath, true);
                                            }
                                        }

                                        //Remove Everything Except Core Files
                                        string[] folderPaths = Directory.GetDirectories(@"C:\driver");
                                        foreach (string folderPath in folderPaths)
                                        {
                                            string name = new DirectoryInfo(folderPath).Name;
                                            
                                            if (name.Contains("NvStreamSrv"))
                                            {
                                                Directory.Delete(folderPath, true);
                                            }
                                            
                                            if (!name.Contains("Display.Driver"))
                                            {
                                                if (!name.Contains("GFExperience"))
                                                {
                                                    if (!name.Contains("NVI2")){

                                                        Directory.Delete(folderPath, true);
                                                    }
                                                }
                                            }
                                        }

                                        //Final File Count
                                        DirectoryInfo finalDir = new DirectoryInfo(@"C:\driver");
                                        int finalFileCount = finalDir.GetFiles().Length;

                                        //Difference Between Original And Final File Count
                                        int difference = originalFileCount - finalFileCount;

                                        MessageBox.Show("All unnecessary files have been removed. Files that have been left are core-barebones required driver files. Do not remove these.", "Successfully Stripped Your Driver");
                                    }
                                    else
                                    {
                                        validationText.Text = @"Could not find file 'C:\driver\setup.cfg'";
                                    }
                                }
                                else
                                {
                                    validationText.Text = @"Could not find file 'C:\driver\ListDevices.txt'";
                                }
                            }
                            else
                            {
                                validationText.Text = @"Could not find file 'C:\driver\EULA.txt'";
                            }
                        }
                        else
                        {
                            validationText.Text = @"Could not find folder 'C:\driver\GFExperience'";
                        }
                    }
                    else
                    {
                        validationText.Text = @"Could not find folder 'C:\driver\Display.Driver'";
                    }
                } 
                else
                {
                    validationText.Text = @"Could not find folder 'C:\driver\NVI2'";
                }
            } 
            else
            {
                validationText.Text = @"Could not find folder 'C:\driver'";
            }
        }

        //Cursor
        private void readyButton_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void dduDownloadLink_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void safeMode_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void Gpu_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.None;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Cross;
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Cross;
        }

        private void Panel3_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Cross;
        }

        private void Panel4_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Cross;
        }

        private void Panel5_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Cross;
        }

        private void DduPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Cross;
        }

        private void select_Leave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }
    }
}
