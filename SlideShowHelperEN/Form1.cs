using System;
using System.Collections.Generic;
using System.Resources;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace SlideShowHelperEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbRandom_CheckedChanged(object sender, EventArgs e)
        {
            if(cbRandom.Checked)
            {
                numPattern.Enabled = true;
            }
            else
            {
                numPattern.Enabled = false;
            }
        }

        

        private void btnColor_Click(object sender, EventArgs e)
        {
            //TODO
            if(DlgColor.ShowDialog()==DialogResult.OK)
            {
                btnColor.BackColor = DlgColor.Color;
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if(DlgFolder.ShowDialog()==DialogResult.OK)
            {
                txtFolder.Text = DlgFolder.SelectedPath;
            }
        }

        private void btnEXO_Click(object sender, EventArgs e)
        {
            if(DlgSaveFile.ShowDialog()==DialogResult.OK && DlgSaveFile.FileName.Length>0)
            {
                txtEXO.Text = DlgSaveFile.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbnSC.Checked = true;
            rbnFX.Checked = false;
            DlgColor.Color = Color.White;
            btnColor.BackColor = Color.White;
            
            //Check culture info
            bool isJP = false;
            String lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            isJP= lang.Equals("ja",StringComparison.OrdinalIgnoreCase);
            if(isJP)
            {
                cbJp.Checked = true;
            }
            else
            {
                cbJp.Checked = false;
            }
            //Set JP UI text
            if(isJP)
            {
                ResourceManager uirm = new ResourceManager("SlideShowHelperEN.JPStringTable", typeof(StringTable).Assembly);
                lblWidth.Text = uirm.GetString("lblWidth");
                lblHeight.Text = uirm.GetString("lblHeight");
                lblFPS.Text = uirm.GetString("lblFPS");
                lblAudRate.Text = uirm.GetString("lblAudRate");
                lblframeA.Text = uirm.GetString("lblFrameUnit");
                lblFrameB.Text = uirm.GetString("lblFrameUnit");
                rbnSC.Text = uirm.GetString("lblSC");
                rbnFX.Text = uirm.GetString("lblSimpleWrap");
                lbl_BG.Text = uirm.GetString("lblBG");
                lblDuration.Text = uirm.GetString("lblDuration");
                lblTransDur.Text = uirm.GetString("lblTransDur");
                cbRandom.Text = uirm.GetString("lblRandom");
                lblMaxPatt.Text = uirm.GetString("lblMaxPatt");
                lblFolder.Text = uirm.GetString("lblFolder");
                lblImgCount.Text = uirm.GetString("lblImgCount");
                cbAsVideo.Text = uirm.GetString("lblAsVideo");
                lblPrefix.Text = uirm.GetString("lblPrefix");
                lblSuffix.Text = uirm.GetString("lblSuffix");
                lblDigits.Text = uirm.GetString("lblDigits");
                lblEXO.Text = uirm.GetString("lblEXO");
                cbJp.Text = uirm.GetString("lblAsJp");
                btnFolder.Text = uirm.GetString("lblBrowse");
                btnEXO.Text = uirm.GetString("lblBrowse");
                btnSave.Text = uirm.GetString("lblSave");
            }
            //MessageBox.Show(lang, "Lang Info");
            //Setup Tool tips
            ToolTip tp = new ToolTip();
            tp.SetToolTip(this.numFramerate, "Numerator of framerate value");
            tp.SetToolTip(this.numScale, "Denominator of framerate value");
            tp.SetToolTip(this.rbnSC, "Use Scene change objects to achieve transistion effects");
            tp.SetToolTip(this.rbnFX, "Use the SimpleWrap V2 FX by TIM to achieve page curl effect");
            tp.SetToolTip(this.btnColor, "Click to open color dialog box");
            tp.SetToolTip(this.numImgDur, String.Format("Image display duration in frames\nCurrent value is around {0,0:F2} seconds", (Double)(numScale.Value*numImgDur.Value/numFramerate.Value)));
            tp.SetToolTip(this.numTranDur, String.Format("Time needed for transistion, must be smaller than the above value\nCurrent value is around {0,0:F2} seconds", (Double)(numScale.Value * numTranDur.Value / numFramerate.Value)));
            tp.SetToolTip(this.cbRandom, "Not applicable to SimpleWrap V2");
            tp.SetToolTip(this.txtFolder, "Folder containing source images.\nNo trailing slash \\ please");
            tp.SetToolTip(this.numImgCount, String.Format("{0,0:D} to {1,0:D} images can be used.", (Int32)numImgCount.Minimum, (Int32)numImgCount.Maximum));
            tp.SetToolTip(this.txtPrefix, "Input image sequence name=\nPrefix+Counter+Suffix\n Excluding folder path. Counter will be zero-padded to the Digit value");
            tp.SetToolTip(this.txtSuffix, "Do not forget adding the file extension here");
            tp.SetToolTip(this.txtEXO, "Output file name");

            //Load setting file
            if(File.Exists("slideshowhelper.xml"))
            {
                try
                {
                    
                    System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(CSetting));
                    System.Xml.XmlReaderSettings xreadSetting = new System.Xml.XmlReaderSettings();
                    xreadSetting.CloseInput = true;
                    System.Xml.XmlReader xreader = System.Xml.XmlReader.Create("slideshowhelper.xml", xreadSetting);
                    CSetting iSetting = (CSetting)xs.Deserialize(xreader);
                    xreader.Close();
                    //Set UI
                    if ((iSetting.width >= numWidth.Minimum) && (iSetting.width <= numWidth.Maximum)) numWidth.Value = iSetting.width;
                    if ((iSetting.height >= numHeight.Minimum) && (iSetting.height <= numHeight.Maximum)) numHeight.Value = iSetting.height;
                    if ((iSetting.fps >= numFramerate.Minimum) && (iSetting.fps <= numFramerate.Maximum)) numFramerate.Value = iSetting.fps;
                    if ((iSetting.scale >= numScale.Minimum) && (iSetting.scale <= numScale.Maximum)) numScale.Value = iSetting.scale;
                    if ((iSetting.audio >= numAudiorate.Minimum) && (iSetting.audio <= numAudiorate.Maximum)) numAudiorate.Value = iSetting.audio;
                    //Transition method
                    if (iSetting.asSC != iSetting.asWrap) { rbnSC.Checked = iSetting.asSC; rbnFX.Checked = iSetting.asWrap; }
                    //BG color
                    btnColor.BackColor = ColorTranslator.FromHtml(iSetting.background);
                    DlgColor.Color = btnColor.BackColor;
                    //Durations
                    if ((iSetting.img_frame >= numImgDur.Minimum) && (iSetting.img_frame <= numImgDur.Maximum)) numImgDur.Value = iSetting.img_frame;
                    if ((iSetting.tra_frame >= numTranDur.Minimum) && (iSetting.tra_frame <= numTranDur.Maximum)) numTranDur.Value = iSetting.tra_frame;
                    //Random SC pattern
                    cbRandom.Checked = iSetting.random;
                    if ((iSetting.sc_pattern >= numPattern.Minimum) && (iSetting.sc_pattern <= numPattern.Maximum)) numPattern.Value = iSetting.sc_pattern;
                    //Filename
                    txtFolder.Text = iSetting.folder;
                    txtPrefix.Text = iSetting.prefix;
                    txtSuffix.Text = iSetting.suffix;
                    txtEXO.Text = iSetting.exo_path;
                    if ((iSetting.img_count >= numImgCount.Minimum) && (iSetting.img_count <= numImgCount.Maximum)) numImgCount.Value = iSetting.img_count;
                    if ((iSetting.digit >= numDigits.Minimum) && (iSetting.digit <= numDigits.Maximum)) numDigits.Value = iSetting.digit;
                    cbAsVideo.Checked = iSetting.asVideo;
                    cbJp.Checked = iSetting.isJP;
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message, "Error parsing setting xml", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO
            //if(true) //DEBUG Use
            if(txtEXO.Text.Length>0) //Main routines go here
            {
                //Calc commonly required param
                UInt32 prjlen = (UInt32)((numImgDur.Value + numTranDur.Value) * numImgCount.Value); //total project length in frames
                UInt32 total_slide_len = (UInt32)(numImgDur.Value + numTranDur.Value);
                UInt32 pmR, pmG, pmB;
                pmR = (UInt32)btnColor.BackColor.R * (UInt32)btnColor.BackColor.A / 255;
                pmG = (UInt32)btnColor.BackColor.G * (UInt32)btnColor.BackColor.A / 255;
                pmB = (UInt32)btnColor.BackColor.B * (UInt32)btnColor.BackColor.A / 255;
                String colorCode = String.Format("{0,0:x2}{1,0:x2}{2,0:x2}", pmR, pmG, pmB);
                //MessageBox.Show(colorCode, "DEBUG");

                //Initialize Resource Manager
                String tableSelector = (this.cbJp.Checked) ? "SlideShowHelperEN.JPStringTable" : "SlideShowHelperEN.StringTable";
                ResourceManager rm = new ResourceManager(tableSelector, typeof(StringTable).Assembly);

                //Initialize a buffer for EXO content
                StringBuilder exo_buffer = new StringBuilder("[exedit]\n");

                //Add global project settings
                exo_buffer.AppendFormat(rm.GetString("IDS_PrjData"), (UInt32)numWidth.Value, (UInt32)numHeight.Value, (UInt32)numFramerate.Value, (UInt32)numScale.Value, (UInt32)prjlen, (UInt32)numAudiorate.Value);
                
                //Add Background
                exo_buffer.AppendFormat(rm.GetString("IDS_Bg"), prjlen, colorCode);

                //Add static image to layer 2
                //Each image has duration: slide+transistion
                UInt32 obj_count = 1; //keep track of total object count
                UInt32 end_frame = 0; //end frame no.
                UInt32 st_frame =1; //start frame no.
                for (UInt32 i = 1; i <= (UInt32)numImgCount.Value; i++ )
                {
                    end_frame += total_slide_len;
                    String fmtStr = "{0}\\{1}{2,0:D" + String.Format("{0,0:D}", (Int32)numDigits.Value) + "}{3}";
                    String imgname = String.Format(fmtStr, txtFolder.Text, txtPrefix.Text, i, txtSuffix.Text);
                    //Add obj section header
                    exo_buffer.AppendFormat("[{0,0:D}]\\n", i);
                    //Add common image param
                    exo_buffer.AppendFormat(rm.GetString("IDS_ImgCommon"), st_frame, end_frame, 2);
                    //Add filename section
                    exo_buffer.AppendFormat("[{0,0:D}.0]\\n", i);
                    //Use different string for Video object
                    if(!cbAsVideo.Checked)
                    {
                        exo_buffer.AppendFormat(rm.GetString("IDS_ImgFile"), imgname);
                    }
                    else
                    {
                        exo_buffer.AppendFormat(rm.GetString("IDS_VidFile"), imgname);
                    }
                    
                    //Add Std Drawing section
                    exo_buffer.AppendFormat("[{0,0:D}.1]\\n", i);
                    exo_buffer.Append(rm.GetString("IDS_ImgStdDrawing"));
                    //End Section, add counter
                    ++obj_count;
                    st_frame = end_frame + 1;
                }
                // Finished Layer 2. Layer 3 will be differ according to transistion method
                // reset st end end frame counters
                st_frame = 0;
                end_frame = 0;

                if(rbnSC.Checked) //Using scenechange objects
                {
                    st_frame += total_slide_len + 1;
                    end_frame = st_frame + (UInt32)numTranDur.Value - 1;
                    Random rndGen= new Random();
                    //Add image_count-1 SC objects
                    for(UInt32 i=1; i<(UInt32)numImgCount.Value; i++)
                    {
                        //Add obj section header
                        exo_buffer.AppendFormat("[{0,0:D}]\\n", obj_count + i-1);
                        //Add SC common param
                        exo_buffer.AppendFormat(rm.GetString("IDS_ScCommon"), st_frame, end_frame, 3);
                        //Check if we need to randomize SC type
                        UInt32 scType = 0;
                        if(cbRandom.Checked)
                        {
                            scType = (UInt32)rndGen.Next(0, (int)numPattern.Value-1);
                        }
                        //Add SC param section
                        exo_buffer.AppendFormat("[{0,0:D}.0]\\n", obj_count + i-1);
                        exo_buffer.AppendFormat(rm.GetString("IDS_ScParam"), scType);

                        //End object. Add counters
                        st_frame += total_slide_len;
                        end_frame = st_frame + (UInt32)numTranDur.Value - 1;
                    }
                }
                else //Using SimpleWrapV2
                {
                    st_frame += total_slide_len + 1;
                    end_frame = st_frame + (UInt32)numTranDur.Value - 1;
                    
                    //Add image_count-1 SC objects
                    for (UInt32 i = 1; i < (UInt32)numImgCount.Value; i++)
                    {
                        //Add obj section header
                        exo_buffer.AppendFormat("[{0,0:D}]\\n", obj_count + i-1);
                        //Add img common param
                        exo_buffer.AppendFormat(rm.GetString("IDS_ImgCommon"), st_frame, end_frame, 3);
                        //Check if we need to randomize SC type
                       

                        //Add filename section
                        String fmtStr = "{0}\\{1}{2,0:D" + String.Format("{0,0:D}", (Int32)numDigits.Value) + "}{3}";
                        String imgname = String.Format(fmtStr, txtFolder.Text, txtPrefix.Text, i, txtSuffix.Text);
                        exo_buffer.AppendFormat("[{0,0:D}.0]\\n", obj_count + i-1);

                        if(!cbAsVideo.Checked)
                        {
                            exo_buffer.AppendFormat(rm.GetString("IDS_ImgFile"), imgname);
                        }
                        else
                        {
                            exo_buffer.AppendFormat(rm.GetString("IDS_VidFile"), imgname);
                        }
                        

                        //Add FX section
                        exo_buffer.AppendFormat("[{0,0:D}.1]\\n", obj_count + i-1);
                        exo_buffer.AppendFormat(rm.GetString("IDS_ImgFX"), (UInt32)(numWidth.Value / 2), (UInt32)(numHeight.Value / 2), (Double)(numWidth.Value * -2), (UInt32)numWidth.Value, (UInt32)numWidth.Value);

                        //Add Std Drawing section
                        exo_buffer.AppendFormat("[{0,0:D}.2]\\n", obj_count + i-1);
                        exo_buffer.Append(rm.GetString("IDS_ImgStdDrawing"));

                        //End object. Add counters
                        st_frame += total_slide_len;
                        end_frame = st_frame + (UInt32)numTranDur.Value - 1;
                    }
                }

                  //Fix newline chars
                  exo_buffer.Replace("\\n", Environment.NewLine);
                    
                  //Save to File (UTF-8)
                  try
                  {
                      //Check culture info
                      bool isJP = cbJp.Checked;
                      
                      if(!isJP)
                      {
                          File.WriteAllText(txtEXO.Text, exo_buffer.ToString());
                          MessageBox.Show("File written successfully!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      }
                      else 
                      {
                          File.WriteAllText(txtEXO.Text, exo_buffer.ToString(), Encoding.GetEncoding(932));
                          MessageBox.Show("EXOの書き出し完了しました！", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      }
                      
                  }
                  catch(Exception error)
                  {
                      //TODO
                      MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  }
                  
                
            }
            else
            {
                MessageBox.Show("Missing EXO filename", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void numTranDur_ValueChanged(object sender, EventArgs e)
        {
            if(numTranDur.Value> numImgDur.Value)
            {
                //numTranDur.Value = numImgDur.Value; //prevent transition longer than Image duration
                numImgDur.BackColor = Color.Yellow;
                numTranDur.BackColor = Color.Yellow;
                numImgDur.ForeColor = Color.Red;
                numTranDur.ForeColor = Color.Red;
            }
            else
            {
                numImgDur.BackColor = Color.White;
                numTranDur.BackColor = Color.White;
                numImgDur.ForeColor = Color.Black;
                numTranDur.ForeColor = Color.Black;
            }
        }

        private void lnkCopyRight_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkCopyRight.LinkVisited = true;
            System.Diagnostics.Process.Start("http://mavericktse.mooo.com/wordpress/");
        }

        private void numImgCount_ValueChanged(object sender, EventArgs e)
        {
            Double maxAllow = Math.Pow(10.0, (Double)numDigits.Value)-1;
            if((Double)numImgCount.Value > maxAllow)
            {
                numImgCount.BackColor = Color.Yellow;
                numImgCount.ForeColor = Color.Red;
                numDigits.BackColor = Color.Yellow;
                numDigits.ForeColor = Color.Red;
            }
            else
            {
                numImgCount.BackColor = Color.White;
                numImgCount.ForeColor = Color.Black;
                numDigits.BackColor = Color.White;
                numDigits.ForeColor = Color.Black;
            }
        }

        private void numDigits_ValueChanged(object sender, EventArgs e)
        {
            Double allow = Math.Pow(10.0, (Double)numDigits.Value) - 1;
            if ((Double)numImgCount.Value > allow)
            {
                numImgCount.BackColor = Color.Yellow;
                numImgCount.ForeColor = Color.Red;
                numDigits.BackColor = Color.Yellow;
                numDigits.ForeColor = Color.Red;
            }
            else
            {
                numImgCount.BackColor = Color.White;
                numImgCount.ForeColor = Color.Black;
                numDigits.BackColor = Color.White;
                numDigits.ForeColor = Color.Black;
            }
        }

        private void numImgDur_ValueChanged(object sender, EventArgs e)
        {
            if(numImgDur.Value<numTranDur.Value)
            {
                numImgDur.BackColor = Color.Yellow;
                numTranDur.BackColor = Color.Yellow;
                numImgDur.ForeColor = Color.Red;
                numTranDur.ForeColor = Color.Red;
            }
            else
            {
                numImgDur.BackColor = Color.White;
                numTranDur.BackColor = Color.White;
                numImgDur.ForeColor = Color.Black;
                numTranDur.ForeColor = Color.Black;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CSetting setting = new CSetting();
            /* Populate settings*/
            setting.width = numWidth.Value;
            setting.height = numHeight.Value;
            setting.fps = numFramerate.Value;
            setting.scale = numScale.Value;
            setting.audio = numAudiorate.Value;
            //
            setting.asSC = rbnSC.Checked;
            setting.asWrap = rbnFX.Checked;
            //
            setting.background = ColorTranslator.ToHtml(btnColor.BackColor);
            setting.img_frame = numImgDur.Value;
            setting.tra_frame = numTranDur.Value;
            setting.random = cbRandom.Checked;
            setting.sc_pattern = numPattern.Value;
            setting.asVideo = cbAsVideo.Checked;
            setting.folder = txtFolder.Text;
            setting.img_count = numImgCount.Value;
            setting.prefix = txtPrefix.Text;
            setting.digit = numDigits.Value;
            setting.suffix = txtSuffix.Text;
            setting.exo_path = txtEXO.Text;
            setting.isJP = cbJp.Checked;
            /*Create serial object*/
            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(setting.GetType());
            /*Write XML*/
            System.Xml.XmlWriterSettings xwsetting = new System.Xml.XmlWriterSettings();
            xwsetting.Encoding = Encoding.UTF8;
            xwsetting.Indent = true;
            System.Xml.XmlWriter xw = System.Xml.XmlWriter.Create("slideshowhelper.xml", xwsetting);
            try
            {
                xs.Serialize(xw, setting);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error writing to Xml Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

 
    }
}
