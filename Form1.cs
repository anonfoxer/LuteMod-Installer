using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//I am well aware a lot of this code is garbage but i don't care, it's a simple tool for a niche game for a mod with an even nicher audience.

namespace LuteModInstaller
{
    public partial class luteModInstaller : Form
    {

        // setting a bunch of variables
        static string currentDir = Directory.GetCurrentDirectory(); // used for assets folder 
        static string assetsPath = currentDir + @"\..\assets"; // Contains the needed .pak files
        static string defaultMordhauPaksPath = @"C:\Program Files\Steam\steamapps\common\Mordhau\Mordhau\Content\Paks"; //Default mordhau install location paks folder
        static string engineIniPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\..\Local\Mordhau\Saved\Config\WindowsClient\Engine.ini"; //engine.ini location
        static string gameIniPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\..\Local\Mordhau\Saved\Config\WindowsClient\Game.ini"; //game.ini location
        static string engineIniContent = @"[/Script/EngineSettings.GameMapsSettings]
GameDefaultMap=/Game/Mordhau/Maps/ClientModMap/ClientMod_MainMenu.ClientMod_MainMenu"; // jargon for engine.ini
        static string gameIniContent = @"[/Game/Mordhau/Maps/ClientModMap/BP_ClientModLoaderActor.BP_ClientModLoaderActor_C]
ClientMods=/Game/Mordhau/Maps/LuteMod/Client/BP_LuteModClientLoader.BP_LuteModClientLoader_C
ModListWidgetStayTime=5.0"; //jargon for game.ini
        static string custPath = ""; //placeholder for custom game install path.

        public luteModInstaller()
        {
            InitializeComponent();
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            #region simpleInstall
            if (simpleInstallCheck.Checked) //Checking to see if simple method
            {
                if (defaultPathCheck.Checked) { //For C: drive locations - simple
                    try
                    {
                        File.Copy(assetsPath + @"\..\LuteMod.pak", defaultMordhauPaksPath);


                        if (File.Exists(defaultMordhauPaksPath + @"\..\LuteMod.pak")) //check that it installed correctly
                        {
                            MessageBox.Show("LuteMod successfully installed, have fun!");
                        }
                        else {
                            MessageBox.Show("LuteMod failed to install.");
                        }
                    }
                    catch( Exception ex )
                    {
                        MessageBox.Show("Error when trying to install: " + ex);
                    }
                }
                else //For any custom locations - simple
                {
                    try
                    {
                        //Copy LuteMod.pak to custPath + Mordhau\Content\Paks
                        File.Copy(assetsPath + @"\..\LuteMod.pak", custPath + @"\..\steamapps\common\Mordhau\Mordhau\Content\Paks");


                        if (File.Exists(custPath + @"\..\steamapps\common\Mordhau\Mordhau\Content\Paks\LuteMod.pak")) //check that it installed correctly
                        {
                            MessageBox.Show("LuteMod successfully installed, have fun!");
                        }
                        else
                        {
                            MessageBox.Show("LuteMod failed to install.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error when trying to install: " + ex);
                    }
                }
            }
            #endregion

            #region fullInstall
            else
            {
                if (defaultPathCheck.Checked) //for C: Drive Locations
                {
                    try
                    {
                        File.Copy(assetsPath + @"\..\LuteMod.pak", defaultMordhauPaksPath);
                        File.Copy(assetsPath + @"\..\zz_clientmodloadingmap_425.pak", defaultMordhauPaksPath);
                        if (!engineIniPath.Contains(engineIniContent))
                        {
                            File.AppendAllText(engineIniPath, engineIniContent); // Append modloader code to .ini files, these dont need a custom path.
                            File.AppendAllText(gameIniPath, gameIniContent);
                        }

                        if (File.Exists(defaultMordhauPaksPath + @"\..\LuteMod.pak")) //check that it installed correctly
                        {
                            MessageBox.Show("LuteMod successfully installed, have fun!");
                        }
                        else
                        {
                            MessageBox.Show("LuteMod failed to install.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error when trying to install: " + ex);
                    }
                }
                else //For any custom locations
                {
                    try
                    {
                        if (custPath != "")
                        {
                            //Copy LuteMod.pak to custPath + Mordhau\Content\Paks
                            File.Copy(assetsPath + @"\..\LuteMod.pak", custPath + @"\..\steamapps\common\Mordhau\Mordhau\Content\Paks");
                            File.Copy(assetsPath + @"\..\zz_clientmodloadingmap_425.pak", custPath + @"\..\steamapps\common\Mordhau\Mordhau\Content\Paks");
                            if (!engineIniPath.Contains(engineIniContent))
                            {
                                File.AppendAllText(engineIniPath, engineIniContent); // Append modloader code to .ini files, these dont need a custom path.
                                File.AppendAllText(gameIniPath, gameIniContent);
                            }

                            if (File.Exists(custPath + @"\..\steamapps\common\Mordhau\Mordhau\Content\Paks\LuteMod.pak")) //check that it installed correctly
                            {
                                MessageBox.Show("LuteMod successfully installed, have fun!");
                            }
                            else
                            {
                                MessageBox.Show("LuteMod failed to install.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a path.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error when trying to install: " + ex);
                    }
                }
            }
            #endregion
        }

        private void pathHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you have Mordhau installed anywhere other than the default C: location, click Browse and select the folder that contains your 'steamapps' folder.");
        }

        private void installOptsHelp_Click(object sender, EventArgs e)
        {
            //Removed feature, ignore me.
        }

        private void pathBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pathbrowser = new FolderBrowserDialog();
            if (pathbrowser.ShowDialog() == DialogResult.OK)
            {
                custPath = pathbrowser.SelectedPath;
                pathDisplayBox.Text = pathbrowser.SelectedPath;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void installOptsHelp_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Enabling simple install will ignore the client side modloader, but will require you to manually load LuteMod on startup by entering \"open lutemod\" in the console. Good if you want to be able to go without lutemod running, or don't want to use the modloader.");
        }

        private void luteModInstaller_Load(object sender, EventArgs e)
        {

        }

        private void defaultPathCheck_CheckedChanged(object sender, EventArgs e)
        {
            pathDisplayBox.Text = defaultMordhauPaksPath;
        }
    }
}

//else if else if else if else if else if else if else if else if else if else if else if else if else if else if else if else if - yandere dev 20212232