using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace GlassLED
{
    public partial class TextPage : Form
    {
        BorderEffectInputForm borderEffectInputForm;
        TextColorChangeSpeedForm textColorChangeSpeedForm;
        BlossomOfSnowForm blossomOfSnowForm;



        /* 속도 */
        public static short v = 0;

        /* 텍스트 페이지 */
        public static byte PageNum = 0;
        public static string[] savedTexts = { "", "", "", "", "" };

        /* 액션 커맨드 */
        public static byte actionCmd = 0;

        /* 입력 문자열의 byte배열 */
        public static List<byte> dataOfInputString = new List<byte>();
        public static int lenOfInputString = 0;

        /* 입력 문자열 */
        public static string inputString = "";

        /* Function Bit */
        public static byte funcBit = 0;

        /* 효과 버튼 */
        byte effectCmb = 0;
        public static bool[] effectUse = new bool[5] { false, false, false, false, false };

        /* 가능 버튼 */
        public bool isthisFuncSave = false;
        /* 기능 중에서 HK 구분용 */
        bool isHKButton = false;

        /* 기능 버튼들 */
        public static bool isClockButtonClicked = false;
        public static bool isWeatherButtonClicked = false;
        public static bool isAirButtonClicked = false;
        public static bool isHKButtonClicked = false;


        public TextPage()
        {
            InitializeComponent();
        }

        #region 액션 버튼
        private void DefaultButton_Click(object sender, EventArgs e)
        {
            actionCmd = 0;
            ChangeActionImage(0);
            DisEnableFuncButtons();
            isthisFuncSave = false;
        }
        private void RightButton_Click(object sender, EventArgs e)
        {
            actionCmd = 1;
            ChangeActionImage(1);
            DisEnableFuncButtons();
            isthisFuncSave = false;
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            actionCmd = 2;
            ChangeActionImage(2);
            DisEnableFuncButtons();
            isthisFuncSave = false;
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            actionCmd = 3;
            ChangeActionImage(3);
            DisEnableFuncButtons();
            isthisFuncSave = false;
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            actionCmd = 4;
            ChangeActionImage(4);
            DisEnableFuncButtons();
            isthisFuncSave = false;
        }

        private void StarButton_Click(object sender, EventArgs e)
        {
            actionCmd = 5;
            ChangeActionImage(5);
            DisEnableFuncButtons();
            isthisFuncSave = false;
        }
        #endregion

        #region 기능 버튼
        public bool EffectUseCheck()
        {
            foreach (bool eu in effectUse)
            {
                if (eu)
                {
                    return true;
                }
            }
            return false;
        }
        private void ClockButton_Click(object sender, EventArgs e)
        {
            if (EffectUseCheck())
            {
                MessageBox.Show("Function button and effect cannot be used together.");
                return;
            }
            if (isClockButtonClicked)
            {
                ClockButton.BackgroundImage = Properties.Resources.function_clock;
                isthisFuncSave = false;
                isHKButton = false;
                isClockButtonClicked = false;
            }
            else
            {
                isClockButtonClicked = true;
                funcBit = Constants.FUNCTION_CLOCK_BIT_MASK;

                ClockButton.BackgroundImage = Properties.Resources.function_clock_clicked;
                WheatherButton.BackgroundImage = Properties.Resources.function_weather;
                AirButton.BackgroundImage = Properties.Resources.air_pollution;
                HKButton.BackgroundImage = Properties.Resources.hongkong;
                DisEnableActionButtons();
                isthisFuncSave = true;
                isHKButton = false;
            }
        }

        private void WheatherButton_Click(object sender, EventArgs e)
        {
            if (Constants.CONNECT_MODE == Constants.BLUETOOTHMODE || Constants.CONNECT_MODE == Constants.DISPLAYMODE)
            {
                MessageBox.Show("날씨 정보는 와이파이 모드에서 요청 가능합니다.");
                return;
            }
            if (EffectUseCheck())
            {
                MessageBox.Show("Function button and effect cannot be used together.");
                return;
            }
            if (isWeatherButtonClicked)
            {
                WheatherButton.BackgroundImage = Properties.Resources.function_weather;
                isthisFuncSave = false;
                isHKButton = false;
                isWeatherButtonClicked = false;
            }
            else
            {
                isWeatherButtonClicked = true;
                funcBit = Constants.FUNCTION_WEATHER_BIT_MASK;

                ClockButton.BackgroundImage = Properties.Resources.function_clock;
                WheatherButton.BackgroundImage = Properties.Resources.function_weather_clicked;
                AirButton.BackgroundImage = Properties.Resources.air_pollution;
                HKButton.BackgroundImage = Properties.Resources.hongkong;
                DisEnableActionButtons();
                isthisFuncSave = true;
                isHKButton = false;
            }
        }

        private void AirButton_Click(object sender, EventArgs e)
        {
            if (Constants.CONNECT_MODE == Constants.BLUETOOTHMODE || Constants.CONNECT_MODE == Constants.DISPLAYMODE)
            {
                MessageBox.Show("미세먼지 정보는 와이파이 모드에서 요청 가능합니다.");
                return;
            }
            if (EffectUseCheck())
            {
                MessageBox.Show("Function button and effect cannot be used together.");
                return;
            }
            if (isAirButtonClicked)
            {
                AirButton.BackgroundImage = Properties.Resources.air_pollution;
                isthisFuncSave = false;
                isHKButton = false;
                isAirButtonClicked = false;
            }
            else
            {
                isAirButtonClicked = true;
                funcBit = Constants.FUNCTION_AIR_POLLUTION_BIT_MASK;

                ClockButton.BackgroundImage = Properties.Resources.function_clock;
                WheatherButton.BackgroundImage = Properties.Resources.function_weather;
                AirButton.BackgroundImage = Properties.Resources.air_pollution_clicked;
                HKButton.BackgroundImage = Properties.Resources.hongkong;
                DisEnableActionButtons();
                isthisFuncSave = true;
                isHKButton = false;
            }

        }
        private void HKButton_Click(object sender, EventArgs e)
        {
            if (Constants.CONNECT_MODE == Constants.BLUETOOTHMODE || Constants.CONNECT_MODE == Constants.DISPLAYMODE)
            {
                MessageBox.Show("미세먼지 정보는 와이파이 모드에서 요청 가능합니다.");
                return;
            }
            if (EffectUseCheck())
            {
                MessageBox.Show("Function button and effect cannot be used together.");
                return;
            }
            if (isHKButtonClicked)
            {
                HKButton.BackgroundImage = Properties.Resources.hongkong;
                isthisFuncSave = true;
                isHKButton = true;
                isHKButtonClicked = false;
            }
            else
            {
                isHKButtonClicked = true;
                ClockButton.BackgroundImage = Properties.Resources.function_clock;
                WheatherButton.BackgroundImage = Properties.Resources.function_weather;
                AirButton.BackgroundImage = Properties.Resources.air_pollution;
                HKButton.BackgroundImage = Properties.Resources.hongkong_clicked;
                DisEnableActionButtons();
                isthisFuncSave = true;
                isHKButton = true;
            }

        }

        #endregion

        #region 효과 버튼
        private void firstEffectButton_Click(object sender, EventArgs e)
        {
            if (isthisFuncSave)
            {
                MessageBox.Show("기능 버튼과 효과를 함께 사용할 수 없습니다.");
                return;
            }
            if (effectUse[3])
            {
                MessageBox.Show("4번째 효과는 다른 어떤 효과와도 함께 사용할 수 없습니다.");
                return;
            }

            if (effectUse[4])
            {
                MessageBox.Show("1,2,3번째 효과는 5번쨰 효과와 함께 사용할 수 없습니다.");
                return;
            }

            if (!effectUse[0])
            {
                effectUse[0] = true;
                firstEffectButton.BackgroundImage = Properties.Resources.effect0_active;
                borderEffectInputForm = new BorderEffectInputForm(this);
                borderEffectInputForm.Show();
            }
            else
            {
                firstEffectButton.BackgroundImage = Properties.Resources.effect0;
                borderEffectInputForm.Close();
                effectUse[0] = false;
            }
        }

        private void seccondEffectButton_Click(object sender, EventArgs e)
        {
            if (isthisFuncSave)
            {
                MessageBox.Show("기능 버튼과 효과를 함께 사용할 수 없습니다.");
                return;
            }
            if (effectUse[3])
            {
                MessageBox.Show("4번째 효과는 다른 어떤 효과와도 함께 사용할 수 없습니다.");
                return;
            }

            if (effectUse[4])
            {
                MessageBox.Show("1,2,3번째 효과는 5번쨰 효과와 함께 사용할 수 없습니다.");
                return;
            }

            if (!effectUse[1])
            {
                effectUse[1] = true;
                seccondEffectButton.BackgroundImage = Properties.Resources.effect1_active;
                textColorChangeSpeedForm = new TextColorChangeSpeedForm(this);
                textColorChangeSpeedForm.Show();
            }
            else
            {
                seccondEffectButton.BackgroundImage = Properties.Resources.effect1;
                effectUse[1] = false;
            }
        }

        private void thirdEffectButton_Click(object sender, EventArgs e)
        {
            if (isthisFuncSave)
            {
                MessageBox.Show("기능 버튼과 효과를 함께 사용할 수 없습니다.");
                return;
            }
            if (effectUse[3])
            {
                MessageBox.Show("4번째 효과는 다른 어떤 효과와도 함께 사용할 수 없습니다.");
                return;
            }

            if (effectUse[4])
            {
                MessageBox.Show("1,2,3번째 효과는 5번쨰 효과와 함께 사용할 수 없습니다.");
                return;
            }

            if (!effectUse[2])
            {
                effectUse[2] = true;
                thridEffectButton.BackgroundImage = Properties.Resources.effect2_active;
                blossomOfSnowForm = new BlossomOfSnowForm(this);
                blossomOfSnowForm.Show();
            }
            else
            {
                thridEffectButton.BackgroundImage = Properties.Resources.effect2;
                effectUse[2] = false;
            }
        }

        private void fourthEffectButton_Click(object sender, EventArgs e)
        {
            if (isthisFuncSave)
            {
                MessageBox.Show("기능 버튼과 효과를 함께 사용할 수 없습니다.");
                return;
            }
            for (int i = 0; i < 5; i++)
            {
                if (i == 3) continue;
                if (effectUse[i])
                {
                    MessageBox.Show("4번째 효과는 다른 어떤 효과와도 함께 사용할 수 없습니다.");
                    return;
                }
            }

            if (!effectUse[3])
            {
                fourthEffectButton.BackgroundImage = Properties.Resources.effect3_active;
                effectUse[3] = true;
            }
            else
            {
                fourthEffectButton.BackgroundImage = Properties.Resources.effect3;
                effectUse[3] = false;
            }
        }

        private void fifthEffectButton_Click(object sender, EventArgs e)
        {
            if (isthisFuncSave)
            {
                MessageBox.Show("기능 버튼과 효과를 함께 사용할 수 없습니다.");
                return;
            }
            if (effectUse[3])
            {
                MessageBox.Show("4번째 효과는 다른 어떤 효과와도 함께 사용할 수 없습니다.");
                return;
            }

            if (effectUse[0] || effectUse[1] || effectUse[2])
            {
                MessageBox.Show("5번째 효과는 1,2,3 효과와 함께 사용할 수 없습니다.");
                return;
            }

            if (!effectUse[4])
            {
                fifthEffectButton.BackgroundImage = Properties.Resources.effect4_active;
                effectUse[4] = true;
            }
            else
            {
                fifthEffectButton.BackgroundImage = Properties.Resources.effect4;
                effectUse[4] = false;
            }
        }
        #endregion

        #region 페이지 버튼

        private void PageOneButton_Click(object sender, EventArgs e)
        {
            PageNum = 0;
            PageButtonClick(PageNum);
        }

        private void PageTwoButton_Click(object sender, EventArgs e)
        {
            PageNum = 1;
            PageButtonClick(PageNum);
        }

        private void PageThreeButton_Click(object sender, EventArgs e)
        {
            PageNum = 2;
            PageButtonClick(PageNum);
        }

        private void PageFourButton_Click(object sender, EventArgs e)
        {
            PageNum = 3;
            PageButtonClick(PageNum);
        }

        private void PageFiveButton_Click(object sender, EventArgs e)
        {
            PageNum = 4;
            PageButtonClick(PageNum);
        }


        private void ClearCurPageButton_Click(object sender, EventArgs e)
        {
            TextInPutBox.Text = "";
        }

        private void ClearAllPageButton_Click(object sender, EventArgs e)
        {
            if (WiFi.client == null) WiFi.MakeDBClient();

            List<byte> dataArea = new List<byte>();
            dataArea.Add(Constants.DELETE_ALL_PAGE);
            Comm.transmit_data(dataArea);
        }
        #endregion

        #region 액션, 기능, 페이지 버튼 활성 비활성 하는 함수들

        public void ChangeActionImage(int number)
        {
            switch (number)
            {
                case 0:
                    DefaultButton.BackgroundImage = Properties.Resources.default_clicked;
                    RightButton.BackgroundImage = Properties.Resources.right;
                    LeftButton.BackgroundImage = Properties.Resources.left;
                    DownButton.BackgroundImage = Properties.Resources.down;
                    UpButton.BackgroundImage = Properties.Resources.up;
                    StarButton.BackgroundImage = Properties.Resources.star;
                    break;
                case 1:
                    DefaultButton.BackgroundImage = Properties.Resources._default;
                    RightButton.BackgroundImage = Properties.Resources.right_clicked;
                    LeftButton.BackgroundImage = Properties.Resources.left;
                    DownButton.BackgroundImage = Properties.Resources.down;
                    UpButton.BackgroundImage = Properties.Resources.up;
                    StarButton.BackgroundImage = Properties.Resources.star;
                    break;
                case 2:
                    DefaultButton.BackgroundImage = Properties.Resources._default;
                    RightButton.BackgroundImage = Properties.Resources.right;
                    LeftButton.BackgroundImage = Properties.Resources.left_clicked;
                    DownButton.BackgroundImage = Properties.Resources.down;
                    UpButton.BackgroundImage = Properties.Resources.up;
                    StarButton.BackgroundImage = Properties.Resources.star;
                    break;
                case 3:
                    DefaultButton.BackgroundImage = Properties.Resources._default;
                    RightButton.BackgroundImage = Properties.Resources.right;
                    LeftButton.BackgroundImage = Properties.Resources.left;
                    DownButton.BackgroundImage = Properties.Resources.down_clicked;
                    UpButton.BackgroundImage = Properties.Resources.up;
                    StarButton.BackgroundImage = Properties.Resources.star;
                    break;
                case 4:
                    DefaultButton.BackgroundImage = Properties.Resources._default;
                    RightButton.BackgroundImage = Properties.Resources.right;
                    LeftButton.BackgroundImage = Properties.Resources.left;
                    DownButton.BackgroundImage = Properties.Resources.down;
                    UpButton.BackgroundImage = Properties.Resources.up_clicked;
                    StarButton.BackgroundImage = Properties.Resources.star;
                    break;
                case 5:
                    DefaultButton.BackgroundImage = Properties.Resources._default;
                    RightButton.BackgroundImage = Properties.Resources.right;
                    LeftButton.BackgroundImage = Properties.Resources.left;
                    DownButton.BackgroundImage = Properties.Resources.down;
                    UpButton.BackgroundImage = Properties.Resources.up;
                    StarButton.BackgroundImage = Properties.Resources.star_clicked;
                    break;
            }
        }
        public void DisEnableActionButtons()
        {
            DefaultButton.BackgroundImage = Properties.Resources._default;
            RightButton.BackgroundImage = Properties.Resources.right;
            LeftButton.BackgroundImage = Properties.Resources.left;
            DownButton.BackgroundImage = Properties.Resources.down;
            UpButton.BackgroundImage = Properties.Resources.up;
            StarButton.BackgroundImage = Properties.Resources.star;
        }

        public void DisEnableFuncButtons()
        {
            ClockButton.BackgroundImage = Properties.Resources.function_clock;
            WheatherButton.BackgroundImage = Properties.Resources.function_weather;
            AirButton.BackgroundImage = Properties.Resources.air_pollution;
            HKButton.BackgroundImage = Properties.Resources.hongkong;
        }

        void PageButtonClick(int pageNum)
        {
            switch (pageNum)
            {
                case 0:
                    PageOneButton.BackColor = Color.Aqua;
                    PageTwoButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageThreeButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageFourButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageFiveButton.BackColor = Color.FromArgb(23, 21, 32);
                    break;
                case 1:
                    PageTwoButton.BackColor = Color.Aqua;
                    PageOneButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageThreeButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageFourButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageFiveButton.BackColor = Color.FromArgb(23, 21, 32);
                    break;
                case 2:
                    PageThreeButton.BackColor = Color.Aqua;
                    PageTwoButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageOneButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageFourButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageFiveButton.BackColor = Color.FromArgb(23, 21, 32);
                    break;
                case 3:
                    PageFourButton.BackColor = Color.Aqua;
                    PageTwoButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageThreeButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageOneButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageFiveButton.BackColor = Color.FromArgb(23, 21, 32);
                    break;
                case 4:
                    PageFiveButton.BackColor = Color.Aqua;
                    PageTwoButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageThreeButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageFourButton.BackColor = Color.FromArgb(23, 21, 32);
                    PageOneButton.BackColor = Color.FromArgb(23, 21, 32);
                    break;
            }
        }
        #endregion

        #region 저장, 미리보기 버튼
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!Comm.IsthereAnyConnect())
            {
                MessageBox.Show("통신 연결이 없습니다");
                return;
            }

            if (isthisFuncSave)
            {
                if (isHKButton)
                {
                    List<byte> dataArea = new List<byte> { Constants.SET_WORLD_WEATHER_DATA, 0, PageNum, 1, 0 };
                    Comm.transmit_data(dataArea);
                }
                else
                {
                    List<byte> dataArea = new List<byte> { Constants.SET_MATRIX_FUNCTION, 0, 0, 0, 0, PageNum, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, funcBit };
                    Comm.transmit_data(dataArea);
                }
            }
            else
            {
                GetUserInput();
                if (v == -1) return;

                /* 데이터 영역 생성 */
                List<byte> dataArea = new List<byte>();
                dataArea.Add(Constants.SAVE_TEXT);
                MakeDataArea(ref dataArea);

                Comm.transmit_data(dataArea);
            }
        }

        private void PreViewButton_Click(object sender, EventArgs e)
        {
            if (!Comm.IsthereAnyConnect())
            {
                MessageBox.Show("통신 연결이 없습니다");
                return;
            }
            if (isthisFuncSave)
            {
                if (isHKButton)
                {
                    List<byte> dataArea = new List<byte> { Constants.SET_WORLD_WEATHER_DATA, 0, PageNum, 0, 0 };
                    Comm.transmit_data(dataArea);
                }
                else
                {
                    List<byte> dataArea = new List<byte> { Constants.SET_MATRIX_FUNCTION, 0, 0, 0, 0, PageNum, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, funcBit };
                    Comm.transmit_data(dataArea);
                }
            }
            else
            {
                GetUserInput();
                if (v == -1) return;

                /* 데이터 영역 생성 */
                List<byte> dataArea = new List<byte>();
                dataArea.Add(Constants.PREVIEW_CMD);
                MakeDataArea(ref dataArea);
                Comm.transmit_data(dataArea);
            }

        }
        #endregion

        public void GetUserInput()
        {
            inputString = TextInPutBox.Text;
            try
            {
                v = short.Parse(SpeedInputTextBox.Text);
            }
            catch
            {
                v = -1;
                MessageBox.Show("속도에 숫자만 입력하세요.");
                return;
            }

            lenOfInputString = inputString.Length;
            dataOfInputString = new List<byte>(Encoding.UTF8.GetBytes(inputString));
            if (lenOfInputString != dataOfInputString.Count)
            {
                lenOfInputString = dataOfInputString.Count;
            }
        }

        public void MakeDataArea(ref List<byte> dataArea)
        {
            /* 데이터 영역 시작 */
            dataArea.Add((byte)0);                                  // 옵션 커맨드
            dataArea.Add((byte)PageNum);                            // 페이지 번호

            dataArea.Add((byte)(lenOfInputString >> 8));            // 문자열 길이 상위 8비트
            dataArea.Add((byte)(lenOfInputString & 0xFF));          // 문자열 길이 하위 8비트

            /* 문자 데이터 */
            foreach (byte b in dataOfInputString)
            {
                dataArea.Add((byte)b);
            }
            if (fontSizeCombo.SelectedItem == null)
            {
                dataArea.Add((byte)1);
            }
            else
            {
                dataArea.Add(byte.Parse(fontSizeCombo.SelectedItem as string));                                  // 문자 크기
            }
            dataArea.Add((byte)31);                                 // 문자 컬러 (r,g,b)  31 흰색
            dataArea.Add((byte)31);                                 // 문자 컬러 (r,g,b) 
            dataArea.Add((byte)31);                                 // 문자 컬러 (r,g,b) 
            dataArea.Add((byte)0);                                  // 문자 배경 컬러 (r,g,b)
            dataArea.Add((byte)0);                                  // 문자 배경 컬러 (r,g,b)
            dataArea.Add((byte)0);                                  // 문자 배경 컬러 (r,g,b)
            dataArea.Add((byte)actionCmd);                          // 액션 커맨드
            dataArea.Add((byte)(v >> 8));                           // 사용자가 입력하는 속도 상위 8비트
            dataArea.Add((byte)(v & 0xFF));                         // 사용자가 입력하는 속도 하위 8비트


            effectCmb = 0;

            for (int i = 0; i < 5; i++)
            {
                if (effectUse[i])
                {
                    effectCmb |= Constants.effectValues[i];
                }
            }

            dataArea.Add((byte)effectCmb);              // 효과 커맨드
            dataArea.Add((byte)(BorderEffectInputForm.blinkTime >> 8));   // 효과 테두리 반짝거리는 타임 상위 8비트
            dataArea.Add((byte)(BorderEffectInputForm.blinkTime & 0xFF)); // 효과 테두리 반짝거리는 타임 하위 8비트
            dataArea.Add((byte)BorderEffectInputForm.r);                  // 효과_테두리 컬러(r,g,b)
            dataArea.Add((byte)BorderEffectInputForm.g);                  // 효과_테두리 컬러(r,g,b)
            dataArea.Add((byte)BorderEffectInputForm.b);                  // 효과_테두리 컬러(r,g,b)

            dataArea.Add(byte.Parse(TextColorChangeSpeedForm.selectedV)); // 효과_텍스트 색상속도 값

            dataArea.Add((byte)(BlossomOfSnowForm.inputSnowV >> 8));             // 효과 별 속도 상위 8비트
            dataArea.Add((byte)(BlossomOfSnowForm.inputSnowV & 0xFF));           // 효과 별 속도 하위 8비트
            /* 데이터 영역 끝 */
        }
        #region 회전 버튼
        private void horizontalButton_Click(object sender, EventArgs e)
        {
            if (!Comm.IsthereAnyConnect())
            {
                MessageBox.Show("통신 연결이 없습니다");
                return;
            }
            List<byte> data = new List<byte>();
            data.Add(Constants.SET_ROTATION_LANDSCAPE);
            Comm.transmit_data(data);
        }

        private void verticalButton_Click(object sender, EventArgs e)
        {
            if (!Comm.IsthereAnyConnect())
            {
                MessageBox.Show("통신 연결이 없습니다");
                return;
            }
            List<byte> data = new List<byte>();
            data.Add(Constants.SET_ROTATION_PORTRAIT);
            Comm.transmit_data(data);
        }
        #endregion
    }
}
