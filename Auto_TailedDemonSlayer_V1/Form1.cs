using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KAutoHelper;

namespace Auto_TailedDemonSlayer_V1
{
    public partial class Form1 : Form
    {
        private bool _isStop = true;
        private bool _allowTrainingLevelUp = true;
        private bool _allowRush = true;
        private bool _allowReturn = true;
        private bool _allowGoldDungeon = true;
        private bool _allowEquipDungeon = true;
        private bool _allowEquipLevelDungeon = true;
        private bool _allowGemDungeon = true;

        private readonly object _locker = new object();

        public Form1()
        {
            InitializeComponent();
            UpdateButtonState();

            _allowTrainingLevelUp = _ckbAllowTraining.Checked;
            _allowRush = _ckbAllowRush.Checked;
            _allowReturn = _ckbAllowReturn.Checked;
            _allowGoldDungeon = _ckbAllowGoldDungeon.Checked;
            _allowEquipDungeon = _ckbAllowEquipDungeon.Checked;
            _allowEquipLevelDungeon = _ckbAllowEquipLevelDungeon.Checked;
            _allowGemDungeon = _ckbAllowGemDungeon.Checked;

            _ckbAllowTraining.CheckedChanged += (s, e) => { _allowTrainingLevelUp = (s as CheckBox).Checked; };
            _ckbAllowRush.CheckedChanged += (s, e) => { _allowRush = (s as CheckBox).Checked; };
            _ckbAllowReturn.CheckedChanged += (s, e) => { _allowReturn = (s as CheckBox).Checked; };
            _ckbAllowGoldDungeon.CheckedChanged += (s, e) => { _allowGoldDungeon = (s as CheckBox).Checked; };
            _ckbAllowEquipDungeon.CheckedChanged += (s, e) => { _allowEquipDungeon = (s as CheckBox).Checked; };
            _ckbAllowEquipLevelDungeon.CheckedChanged += (s, e) => { _allowEquipLevelDungeon = (s as CheckBox).Checked; };
            _ckbAllowGemDungeon.CheckedChanged += (s, e) => { _allowGemDungeon = (s as CheckBox).Checked; };
        }

        private void _btnStart_Click(object sender, EventArgs e)
        {
            if (_isStop)
            {
                _isStop = false;
                _lbDeviceId.Text = "";
                string deviceID = null;
                var listDevice = ADBHelper.GetDevices();
                if (listDevice != null && listDevice.Count > 0)
                {
                    deviceID = listDevice.First();
                }
                _lbDeviceId.Text = deviceID;
                Task.Run(() => DoWork(deviceID));
                Task.Run(() => ClearConversationAndAdvertise(deviceID));
            }
            UpdateButtonState();
        }

        private void _btnStop_Click(object sender, EventArgs e)
        {
            _lbDeviceId.Text = "";
            _isStop = true;
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            _btnStart.Enabled = _isStop;
            _btnStop.Enabled = !_isStop;
        }

        private void Delay(int second)
        {
            while (second > 0)
            {
                if (_isStop)
                    throw new Exception("Delay error device was stoped");
                Thread.Sleep(1000);
                second--;
            }
        }

        private Point? FindImagePoint(string deviceId, string imgPath, int tryTimes = 1, int delay = 1000, double percent = 0.9)
        {
            try
            {
                if (File.Exists(imgPath))
                {
                    Bitmap bm = (Bitmap)Image.FromFile(imgPath);
                    if (bm != null)
                    {
                        for (int i = 0; i < tryTimes; i++)
                        {
                            lock (_locker)
                            {
                                var screen = ADBHelper.ScreenShoot(deviceId);
                                if (screen != null)
                                {
                                    var point = ImageScanOpenCV.FindOutPoint(screen, bm, percent); ;
                                    if (point != null)
                                    {
                                        return point;
                                    }
                                }
                            }
                            Thread.Sleep(delay);
                        }
                    }
                }
            }
            catch { }
            return null;
        }

        private bool ClickToImage(string deviceId, string imgPath, int count = 1, int tryTimes = 1, int delay = 3000, double percent = 0.9)
        {
            try
            {
                var point = FindImagePoint(deviceId, imgPath, tryTimes, delay, percent);
                if (point != null)
                {
                    ADBHelper.Tap(deviceId, point.Value.X, point.Value.Y, count);
                    return true;
                }
            }
            catch { }
            return false;
        }

        private void CheckStop(string deviceId)
        {
            if (_isStop)
            {
                throw new Exception($"Device '{deviceId}' was stoped.");
            }
        }

        private void DoWork(string deviceId)
        {
            try
            {
                string id = deviceId;

                while (!_isStop)
                {
                    DoTraining(id);
                    Delay(5);
                    DoRush(id);
                    Delay(5);
                    DoReturn(id);
                    Delay(5);
                    DoDungeon(id);
                    Delay(5);
                }
            }
            catch { }
        }

        private void ClearConversationAndAdvertise(string deviceId)
        {
            try
            {
                string id = deviceId;

                while (!_isStop)
                {
                    if (ClickToImage(deviceId, "Images/conversation.png", 50, 1, 1))
                    {

                    }

                    if (ClickToImage(deviceId, "Images/ribbon.png", 50, 1, 1))
                    {

                    }

                    Delay(5);
                }
            }
            catch { }
        }

        private void DoTraining(string deviceId)
        {
            CheckStop(deviceId);
            if (_allowTrainingLevelUp)
            {
                if (ClickToImage(deviceId, "Images/training.png"))
                {
                    Delay(2);
                    var upPoint = FindImagePoint(deviceId, "Images/training_up.png");
                    if (upPoint != null)
                    {
                        lock (_locker)
                        {
                            ADBHelper.LongPress(deviceId, upPoint.Value.X, upPoint.Value.Y, 1000);
                        }
                    }

                    Delay(1);
                    ClickToImage(deviceId, "Images/training_cancel.png");
                    Delay(2);
                }
            }
        }

        private void DoRush(string deviceId)
        {
            CheckStop(deviceId);
            if (_allowRush)
            {
                if (ClickToImage(deviceId, "Images/rush.png"))
                {
                    Delay(5);
                }
            }
        }

        private void DoReturn(string deviceId)
        {
            CheckStop(deviceId);
            if (_allowReturn)
            {
                if (ClickToImage(deviceId, "Images/return.png"))
                {
                    Delay(2);
                    if (ClickToImage(deviceId, "Images/return_confirm.png"))
                    {
                        Delay(2);
                        if (ClickToImage(deviceId, "Images/return_confirm.png"));
                        {
                            Delay(10);
                            ClickToImage(deviceId, "Images/ribbon.png");
                        }
                    }
                    else
                    {
                        ClickToImage(deviceId, "Images/return_cancel.png");
                    }
                }
            }
        }

        private void DoDungeon(string deviceId)
        {
            CheckStop(deviceId);
            
            if (_allowGemDungeon ||
                _allowEquipDungeon ||
                _allowEquipLevelDungeon ||
                _allowGoldDungeon)
            {
                if (ClickToImage(deviceId, "Images/dugeon.png"))
                {
                    Delay(2);

                    if (GoGemDungeon(deviceId))
                    {
                        ADBHelper.TapByPercent(deviceId, 52.3, 31.3);
                        return;
                    }

                    if (GoGoldDungeon(deviceId))
                    {
                        ADBHelper.TapByPercent(deviceId, 52.3, 31.3); 
                        return;
                    }

                    if (GoEquipDungeon(deviceId))
                    {
                        ADBHelper.TapByPercent(deviceId, 52.3, 31.3);
                        return;
                    }

                    if (GoEquipLevelDungeon(deviceId))
                    {
                        ADBHelper.TapByPercent(deviceId, 52.3, 31.3);
                        return;
                    }

                    ADBHelper.TapByPercent(deviceId, 52.3, 31.3);
                }
            }
        }

        private bool GoGemDungeon(string deviceId)
        {
            CheckStop(deviceId);
            if (_allowGemDungeon)
            {
                if (ClickToImage(deviceId, "Images/dungeon_gem.png"))
                {
                    Delay(2);
                    ClickToImage(deviceId, "Images/dungeon_enter.png");
                    Delay(2);
                    ClickToImage(deviceId, "Images/dungeon_cancel.png");
                    Delay(2);
                }
            }
            return false;
        }

        private bool GoGoldDungeon(string deviceId)
        {
            CheckStop(deviceId);
            if (_allowGoldDungeon)
            {
                if (ClickToImage(deviceId, "Images/dungeon_gold.png"))
                {
                    Delay(2);
                    ClickToImage(deviceId, "Images/dungeon_enter.png");
                    Delay(2);
                    ClickToImage(deviceId, "Images/dungeon_cancel.png");
                    Delay(2);
                }
            }
            return false;
        }

        private bool GoEquipLevelDungeon(string deviceId)
        {
            CheckStop(deviceId);
            if (_allowEquipLevelDungeon)
            {
                if (ClickToImage(deviceId, "Images/dungeon_equip_level.png"))
                {
                    Delay(2);
                    ClickToImage(deviceId, "Images/dungeon_enter.png");
                    Delay(2);
                    ClickToImage(deviceId, "Images/dungeon_cancel.png");
                    Delay(2);
                }
            }
            return false;
        }

        private bool GoEquipDungeon(string deviceId)
        {
            CheckStop(deviceId);
            if (_allowEquipDungeon)
            {
                if (ClickToImage(deviceId, "Images/dungeon_equip.png"))
                {
                    Delay(2);
                    ClickToImage(deviceId, "Images/dungeon_enter.png");
                    Delay(2);
                    ClickToImage(deviceId, "Images/dungeon_cancel.png");
                    Delay(2);
                }
            }
            return false;
        }
    }
}
