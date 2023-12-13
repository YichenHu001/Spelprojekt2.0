using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;
using System;

namespace _21
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        SpriteFont Arial;
        SpriteFont Times_New_Roman_36;
        SpriteFont Times_New_Roman_48;


        string Game_Title = "No Game No life";
        string Secend_Game_Title = "Gambling Master!!!";
        string Text_Start = "START";
        string Text_Options = "OPTIONS";
        Vector2 Text_Start_Position = new Vector2(725, 350 * 2);
        Vector2 Text_Options_Position = new Vector2(700, 410 * 2);
        Vector2 Game_Title_Position = new Vector2(80, 24);
        Vector2 Secend_Game_Title_Position = new Vector2(260, 120);
        Texture2D Start_Button;
        Texture2D Options_Button;
        Texture2D Title_Page;
        Rectangle Start_Button_Position = new Rectangle(707, 340 * 2, 185, 44 * 2);
        Rectangle Options_Button_Position = new Rectangle(680, 400 * 2, 240, 44 * 2);
        Rectangle Title_Page_Position = new Rectangle(0, 0, 850 * 2, 530 * 2);


        string Options_Page_Title = "Options";
        Texture2D Options_Page;
        Texture2D Options_Page_Close_Button_Grey;
        Texture2D Options_Page_Close_Button_Red;
        Texture2D Options_Page_Music_Change_Left_Button;
        Texture2D Options_Page_Music_Change_Right_Button;
        Texture2D Options_Page_Music_Display_Location;
        Texture2D Red_Cross;
        // false = open
        // true = close
        bool Music_Open_Or_Close = false;
        string Text_Music_Change = "Music Change";
        Vector2 Options_Page_Title_Position = new Vector2(40, 25);
        Rectangle Options_Page_Position = new Rectangle(-50, -50 - 1000, 1700, 1060);
        Rectangle Options_Page_Close_Button_Position = new Rectangle(775, 30 - 1000, 50, 50);
        Rectangle Options_page_Music_change_Left_Button_Position = new Rectangle(50, 300 - 1000, 50, 60);
        Rectangle Options_Page_Music_Display_Location_Position = new Rectangle(150, 300 - 1000, 300, 60);
        Rectangle Options_page_Music_change_Right_Button_Position = new Rectangle(500, 300 - 1000, 50, 60);
        Vector2 Text_Music_Change_Position = new Vector2(160, 300 - 1000);


        Texture2D Mouse_Cursor;
        Texture2D Mouse_Finger;
        Rectangle Mouse_Cursor_Position = new Rectangle(0, 0, 30, 45);


        List<Texture2D> Player_Cards = new List<Texture2D>();
        List<Texture2D> Robot_Cards = new List<Texture2D>();
        List<int> Player_Cards_Score = new List<int>();
        List<int> Robot_Cards_Score = new List<int>();
        bool Game_Start = false;
        bool RobotTurn = false;
        Texture2D Game_Background;
        Texture2D Game_Need_More_Card_Button;
        Texture2D Game_Stop_Button;
        Texture2D Game_Robot_Score_Display_Location;
        Texture2D Game_Player_Score_Display_Location;
        Texture2D Game_Options_Button;
        string Text_Need_More_Card = "Need More Card";
        string Text_Stop = "Stop";
        Rectangle Game_Background_Position = new Rectangle(0, 0, 1600, 960);
        Rectangle Player_Card_Position_1 = new Rectangle(700, 700, 70, 70);
        Rectangle Player_Card_Position_2 = new Rectangle(800, 700, 70, 70);
        Rectangle Game_Need_More_Card_Button_Position = new Rectangle(100, 560, 325, 60);
        Rectangle Game_Stop_Button_Position = new Rectangle(1100, 560, 325, 60);
        Vector2 Text_Need_More_Card_Position = new Vector2(100, 560);
        Vector2 Player_Score_Position = new Vector2(765, 475);
        Vector2 Text_Stop_Position = new Vector2(1225, 560);
        Rectangle Robot_Card_Position_1 = new Rectangle(660, 100, 70, 70);
        Rectangle Robot_Card_Position_2 = new Rectangle(835, 100, 70, 70);
        Vector2 Robot_Score_Position = new Vector2(770, 100);
        Rectangle Game_Robot_Score_Display_Location_Position = new Rectangle(765, 100, 60, 60);
        Rectangle Game_Player_Score_Display_Location_Position = new Rectangle(760, 475, 60, 60);
        Rectangle Game_Options_Button_Position = new Rectangle(0, 0, 50, 50);
        int PlayerScore;
        int RobotScore;


        bool Initial_Page = true;
        bool Cursor_Or_Finger = true;
        // true = cursor
        // false = false
        bool Options_Page_Open_Or_Close = false;
        bool Grey_Or_Red = true;


        int music_num = 1;
        int Tmp_Card;
        int Time = 0;

        MouseState mouse = Mouse.GetState();
        MouseState oldmouse = Mouse.GetState();
        KeyboardState keyboard = Keyboard.GetState();
        KeyboardState oldkeyboard = Keyboard.GetState();

        Song Music0;
        Song Music1;
        Song Music2;

        SoundEffect Click_valid;
        SoundEffect Click_Invalid;
        SoundEffect Give_Cards;
        SoundEffect Shuffle;
        SoundEffect Fail_Sound;

        Dictionary<int, Texture2D> All_Cards = new Dictionary<int, Texture2D>();

        Texture2D C2;
        Texture2D C3;
        Texture2D C4;
        Texture2D C5;
        Texture2D C6;
        Texture2D C7;
        Texture2D C8;
        Texture2D C9;
        Texture2D C10;
        Texture2D CJ;
        Texture2D CQ;
        Texture2D CK;
        Texture2D CA;

        Texture2D D2;
        Texture2D D3;
        Texture2D D4;
        Texture2D D5;
        Texture2D D6;
        Texture2D D7;
        Texture2D D8;
        Texture2D D9;
        Texture2D D10;
        Texture2D DJ;
        Texture2D DQ;
        Texture2D DK;
        Texture2D DA;

        Texture2D H2;
        Texture2D H3;
        Texture2D H4;
        Texture2D H5;
        Texture2D H6;
        Texture2D H7;
        Texture2D H8;
        Texture2D H9;
        Texture2D H10;
        Texture2D HJ;
        Texture2D HQ;
        Texture2D HK;
        Texture2D HA;

        Texture2D S2;
        Texture2D S3;
        Texture2D S4;
        Texture2D S5;
        Texture2D S6;
        Texture2D S7;
        Texture2D S8;
        Texture2D S9;
        Texture2D S10;
        Texture2D SJ;
        Texture2D SQ;
        Texture2D SK;
        Texture2D SA;

        Texture2D Card_Back;



        Random RandomNum = new Random();


        List<int> Card_Typ_Clubs = new List<int>();
        List<int> Card_Typ_Diamonds = new List<int>();
        List<int> Card_Typ_Hearts = new List<int>();
        List<int> Card_Typ_Spades = new List<int>();


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;

            _graphics.PreferredBackBufferWidth = 1600;
            _graphics.PreferredBackBufferHeight = 960;




        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            for (int i = 1; i < 14; i++)
            {
                Card_Typ_Clubs.Add(i);
            }
            for (int i = 1; i < 14; i++)
            {
                Card_Typ_Diamonds.Add(i);
            }
            for (int i = 1; i < 14; i++)
            {
                Card_Typ_Hearts.Add(i);
            }
            for (int i = 1; i < 14; i++)
            {
                Card_Typ_Spades.Add(i);
            }
            //Club     = 0
            //Diamonds = 1
            //Hearts   = 2
            //Spades   = 3


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Arial = Content.Load<SpriteFont>("Arial");
            Times_New_Roman_36 = Content.Load<SpriteFont>("Times New Roman 36");
            Times_New_Roman_48 = Content.Load<SpriteFont>("Times New Roman 48");
            Start_Button = Content.Load<Texture2D>("yellow_button00");
            Options_Button = Content.Load<Texture2D>("yellow_button00");
            Mouse_Cursor = Content.Load<Texture2D>("cursor_pointer3D");
            Mouse_Finger = Content.Load<Texture2D>("cursor_hand");
            Title_Page = Content.Load<Texture2D>("21点封面素材");

            Options_Page = Content.Load<Texture2D>("metalPanel_yellow");
            Options_Page_Close_Button_Grey = Content.Load<Texture2D>("grey_crossGrey");
            Options_Page_Close_Button_Red = Content.Load<Texture2D>("red_cross");
            Options_Page_Music_Change_Left_Button = Content.Load<Texture2D>("yellow_sliderLeft");
            Options_Page_Music_Change_Right_Button = Content.Load<Texture2D>("yellow_sliderRight");
            Options_Page_Music_Display_Location = Content.Load<Texture2D>("yellow_button00");
            Red_Cross = Content.Load<Texture2D>("red_cross");

            Game_Background = Content.Load<Texture2D>("21点桌面2.0");
            Game_Player_Score_Display_Location = Content.Load<Texture2D>("yellow_button00");
            Game_Robot_Score_Display_Location = Content.Load<Texture2D>("yellow_button00");
            Game_Options_Button = Content.Load<Texture2D>("gear");
            Game_Need_More_Card_Button = Content.Load<Texture2D>("yellow_button00");
            Game_Stop_Button = Content.Load<Texture2D>("yellow_button00");

            Music0 = Content.Load<Song>("Snowland Loop Short");
            Music1 = Content.Load<Song>("Woodland Fantasy");
            Music2 = Content.Load<Song>("enchanted tiki 86");

            Click_valid = Content.Load<SoundEffect>("jingles_PIZZI00");
            Click_Invalid = Content.Load<SoundEffect>("jingles_PIZZI16");
            Give_Cards = Content.Load<SoundEffect>("cardSlide5");
            Shuffle = Content.Load<SoundEffect>("cardFan2");
            Fail_Sound = Content.Load<SoundEffect>("jingles_SAX01");



            MediaPlayer.IsRepeating = true;
            MediaPlayer.Play(Music1);

            C2 = Content.Load<Texture2D>("card_clubs_02");
            C3 = Content.Load<Texture2D>("card_clubs_03");
            C4 = Content.Load<Texture2D>("card_clubs_04");
            C5 = Content.Load<Texture2D>("card_clubs_05");
            C6 = Content.Load<Texture2D>("card_clubs_06");
            C7 = Content.Load<Texture2D>("card_clubs_07");
            C8 = Content.Load<Texture2D>("card_clubs_08");
            C9 = Content.Load<Texture2D>("card_clubs_09");
            C10 = Content.Load<Texture2D>("card_clubs_10");
            CJ = Content.Load<Texture2D>("card_clubs_J");
            CQ = Content.Load<Texture2D>("card_clubs_Q");
            CK = Content.Load<Texture2D>("card_clubs_K");
            CA = Content.Load<Texture2D>("card_clubs_A");

            D2 = Content.Load<Texture2D>("card_diamonds_02");
            D3 = Content.Load<Texture2D>("card_diamonds_03");
            D4 = Content.Load<Texture2D>("card_diamonds_04");
            D5 = Content.Load<Texture2D>("card_diamonds_05");
            D6 = Content.Load<Texture2D>("card_diamonds_06");
            D7 = Content.Load<Texture2D>("card_diamonds_07");
            D8 = Content.Load<Texture2D>("card_diamonds_08");
            D9 = Content.Load<Texture2D>("card_diamonds_09");
            D10 = Content.Load<Texture2D>("card_diamonds_10");
            DJ = Content.Load<Texture2D>("card_diamonds_J");
            DQ = Content.Load<Texture2D>("card_diamonds_Q");
            DK = Content.Load<Texture2D>("card_diamonds_K");
            DA = Content.Load<Texture2D>("card_diamonds_A");

            H2 = Content.Load<Texture2D>("card_hearts_02");
            H3 = Content.Load<Texture2D>("card_hearts_03");
            H4 = Content.Load<Texture2D>("card_hearts_04");
            H5 = Content.Load<Texture2D>("card_hearts_05");
            H6 = Content.Load<Texture2D>("card_hearts_06");
            H7 = Content.Load<Texture2D>("card_hearts_07");
            H8 = Content.Load<Texture2D>("card_hearts_08");
            H9 = Content.Load<Texture2D>("card_hearts_09");
            H10 = Content.Load<Texture2D>("card_hearts_10");
            HJ = Content.Load<Texture2D>("card_hearts_J");
            HQ = Content.Load<Texture2D>("card_hearts_Q");
            HK = Content.Load<Texture2D>("card_hearts_K");
            HA = Content.Load<Texture2D>("card_hearts_A");


            S2 = Content.Load<Texture2D>("card_spades_02");
            S3 = Content.Load<Texture2D>("card_spades_03");
            S4 = Content.Load<Texture2D>("card_spades_04");
            S5 = Content.Load<Texture2D>("card_spades_05");
            S6 = Content.Load<Texture2D>("card_spades_06");
            S7 = Content.Load<Texture2D>("card_spades_07");
            S8 = Content.Load<Texture2D>("card_spades_08");
            S9 = Content.Load<Texture2D>("card_spades_09");
            S10 = Content.Load<Texture2D>("card_spades_10");
            SJ = Content.Load<Texture2D>("card_spades_J");
            SQ = Content.Load<Texture2D>("card_spades_Q");
            SK = Content.Load<Texture2D>("card_spades_K");
            SA = Content.Load<Texture2D>("card_spades_A");

            Card_Back = Content.Load<Texture2D>("card_back");

            All_Cards[1] = CA;
            All_Cards[2] = C2;
            All_Cards[3] = C3;
            All_Cards[4] = C4;
            All_Cards[5] = C5;
            All_Cards[6] = C6;
            All_Cards[7] = C7;
            All_Cards[8] = C8;
            All_Cards[9] = C9;
            All_Cards[10] = C10;
            All_Cards[11] = CJ;
            All_Cards[12] = CQ;
            All_Cards[13] = CK;

            All_Cards[14] = DA;
            All_Cards[15] = D2;
            All_Cards[16] = D3;
            All_Cards[17] = D4;
            All_Cards[18] = D5;
            All_Cards[19] = D6;
            All_Cards[20] = D7;
            All_Cards[21] = D8;
            All_Cards[22] = D9;
            All_Cards[23] = D10;
            All_Cards[24] = DJ;
            All_Cards[25] = DQ;
            All_Cards[26] = DK;

            All_Cards[27] = HA;
            All_Cards[28] = H2;
            All_Cards[29] = H3;
            All_Cards[30] = H4;
            All_Cards[31] = H5;
            All_Cards[32] = H6;
            All_Cards[33] = H7;
            All_Cards[34] = H8;
            All_Cards[35] = H9;
            All_Cards[36] = H10;
            All_Cards[37] = HJ;
            All_Cards[38] = HQ;
            All_Cards[39] = HK;

            All_Cards[40] = SA;
            All_Cards[41] = S2;
            All_Cards[42] = S3;
            All_Cards[43] = S4;
            All_Cards[44] = S5;
            All_Cards[45] = S6;
            All_Cards[46] = S7;
            All_Cards[47] = S8;
            All_Cards[48] = S9;
            All_Cards[49] = S10;
            All_Cards[50] = SJ;
            All_Cards[51] = SQ;
            All_Cards[52] = SK;

            All_Cards[53] = Card_Back;


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            oldmouse = mouse;
            mouse = Mouse.GetState();
            Mouse_Cursor_Position.X = mouse.X - Mouse_Cursor_Position.Width / 2;
            Mouse_Cursor_Position.Y = mouse.Y - Mouse_Cursor_Position.Height / 2;

            oldkeyboard = keyboard;
            keyboard = Keyboard.GetState();


            Cursor_Or_Finger = true;
            Grey_Or_Red = true;

            PlayerScore = Player_Score();
            RobotScore = Robot_Score();



            if (Card_Typ_Clubs.Count + Card_Typ_Diamonds.Count + Card_Typ_Hearts.Count + Card_Typ_Spades.Count == 0)
            {
                Shuffle_Cards();
            }

            if (Cursor_Or_Finger == false && mouse.LeftButton == ButtonState.Pressed && oldmouse.LeftButton == ButtonState.Released)
            {
                Click_valid.Play();
            }
            if (Cursor_Or_Finger == true && mouse.LeftButton == ButtonState.Pressed && oldmouse.LeftButton == ButtonState.Released)
            {
                Click_Invalid.Play();
            }
            if (Mouse_Cursor_Position.Intersects(Options_Button_Position))
            {
                Cursor_Or_Finger = false;
            }
            if ((Mouse_Cursor_Position.Intersects(Options_Button_Position) && mouse.LeftButton == ButtonState.Pressed && oldmouse.LeftButton == ButtonState.Released) || (keyboard.IsKeyDown(Keys.Escape) && oldkeyboard.IsKeyUp(Keys.Escape)))
            {
                Options_Page_Open_Or_Close = true;
                Initial_Page_Remove_All();
                All_Options_Page_Back();
            }
            if (Mouse_Cursor_Position.Intersects(Options_Page_Close_Button_Position))
            {
                Cursor_Or_Finger = false;
                Grey_Or_Red = false;
            }
            if (Game_Start == true && Mouse_Cursor_Position.Intersects(Options_Page_Close_Button_Position) && mouse.LeftButton == ButtonState.Pressed && oldmouse.LeftButton == ButtonState.Released)
            {
                Options_Page_Open_Or_Close = false;
                All_Game_Page_Back();
                Options_Page_Remove_All();
            }
            if (Mouse_Cursor_Position.Intersects(Options_Page_Close_Button_Position) && mouse.LeftButton == ButtonState.Pressed && oldmouse.LeftButton == ButtonState.Released)
            {
                Options_Page_Open_Or_Close = false;
                All_Initial_Page_Back();
                Options_Page_Remove_All();
            }


            if (Mouse_Cursor_Position.Intersects(Options_page_Music_change_Right_Button_Position))
            {
                Cursor_Or_Finger = false;
            }
            if (Mouse_Cursor_Position.Intersects(Options_page_Music_change_Right_Button_Position) && mouse.LeftButton == ButtonState.Pressed && oldmouse.LeftButton == ButtonState.Released)
            {
                if (music_num == 2)
                {
                    music_num = 0;
                }
                else
                {
                    music_num++;
                }
                Music_Choose();
            }
            if (Mouse_Cursor_Position.Intersects(Options_page_Music_change_Left_Button_Position))
            {
                Cursor_Or_Finger = false;
            }
            if (Mouse_Cursor_Position.Intersects(Options_page_Music_change_Left_Button_Position) && mouse.LeftButton == ButtonState.Pressed && oldmouse.LeftButton == ButtonState.Released)
            {
                if (music_num == 0)
                {
                    music_num = 2;
                }
                else
                {
                    music_num--;
                }
                Music_Choose();
            }
            if (Mouse_Cursor_Position.Intersects(Options_Page_Music_Display_Location_Position))
            {
                Cursor_Or_Finger = false;
            }
            if (Mouse_Cursor_Position.Intersects(Options_Page_Music_Display_Location_Position) && mouse.LeftButton == ButtonState.Pressed && oldmouse.LeftButton == ButtonState.Released)
            {
                if (music_num != 3)
                {
                    music_num = 3;
                }
                else
                    music_num = 0;
                Music_Open_Or_Close = !Music_Open_Or_Close;
                Music_Choose();
            }

            //Game Start

            if (Mouse_Cursor_Position.Intersects(Start_Button_Position))
            {
                Cursor_Or_Finger = false;
            }
            if (Mouse_Cursor_Position.Intersects(Start_Button_Position) && mouse.LeftButton == ButtonState.Pressed && oldmouse.LeftButton == ButtonState.Released)
            {
                Cursor_Or_Finger = false;
                Initial_Page = false;
                Game_Start = true;
                Initial_Page_Remove_All();
                GameStart();
            }
            if (Beyond_21_Player())
            {
                Time++;
                if (Time == 30)
                {
                    New_turn();
                    Time = 0;
                }
            }
            if (Mouse_Cursor_Position.Intersects(Game_Need_More_Card_Button_Position))
            {
                Cursor_Or_Finger = false;
            }
            if (Mouse_Cursor_Position.Intersects(Game_Need_More_Card_Button_Position) && mouse.LeftButton == ButtonState.Pressed && oldmouse.LeftButton == ButtonState.Released)
            {
                Player_Data();
            }

            if (Mouse_Cursor_Position.Intersects(Game_Stop_Button_Position))
            {
                Cursor_Or_Finger = false;
            }
            if (Mouse_Cursor_Position.Intersects(Game_Stop_Button_Position) && mouse.LeftButton == ButtonState.Pressed && oldmouse.LeftButton == ButtonState.Released)
            {
                RobotTurn = true;
            }
            if (RobotTurn == true)
            {
                Time++;
                if (Time == 45)
                {
                    Robot_Turn();
                    Time = 0;
                }
            }
            if (Mouse_Cursor_Position.Intersects(Game_Options_Button_Position))
            {
                Cursor_Or_Finger = false;
            }
            if (Mouse_Cursor_Position.Intersects(Game_Options_Button_Position) && mouse.LeftButton == ButtonState.Pressed && oldmouse.LeftButton == ButtonState.Released)
            {
                Options_Page_Open_Or_Close = true;
                Game_Page_Remove_All();
                All_Options_Page_Back();
            }


            void Robot_Turn()
            {
                Give_Cards.Play();
                if (Robot_Score() <= PlayerScore && Robot_Score() < 21)
                {
                    Robot_Data();
                }
                else
                {
                    New_turn();
                }
            }

            void New_turn()
            {
                Fail_Sound.Play();
                Player_Cards_Score.Clear();
                Robot_Cards_Score.Clear();
                Player_Cards.Clear();
                Robot_Cards.Clear();
                RobotTurn = false;
                GameStart();
            }

            int Player_Score()
            {
                int Player_Cards_Score_Sum = 0;
                for (int i = 0; i < Player_Cards_Score.Count; i++)
                {
                    if (Player_Cards_Score[i] > 10)
                    {
                        Player_Cards_Score_Sum += 10;
                    }
                    else
                    {
                        Player_Cards_Score_Sum += Player_Cards_Score[i];
                    }
                }
                if (Player_Cards_Score.Contains(1) && Player_Cards_Score_Sum <= 11)
                {
                    Player_Cards_Score_Sum += 10;
                }

                return Player_Cards_Score_Sum;
            }

            int Robot_Score()
            {
                int Robot_Cards_Score_Sum = 0;
                for (int i = 0; i < Robot_Cards_Score.Count; i++)
                {
                    if (Robot_Cards_Score[i] > 10)
                    {
                        Robot_Cards_Score_Sum += 10;
                    }
                    else
                    {
                        Robot_Cards_Score_Sum += Robot_Cards_Score[i];
                    }
                }
                if (Robot_Cards_Score.Contains(1) && Robot_Cards_Score_Sum <= 11)
                {
                    Robot_Cards_Score_Sum += 10;
                }

                return Robot_Cards_Score_Sum;
            }

            bool Beyond_21_Robot()
            {
                if (Robot_Score() > 21)
                {
                    return true;
                }
                else
                    return false;
            }

            bool Beyond_21_Player()
            {
                if (Player_Score() > 21)
                {
                    return true;
                }
                else
                    return false;
            }

            void GameStart()
            {
                Player_Data();
                Robot_Data();
                Player_Data();
                Robot_Data();
            }


            void Player_Data()
            {
                int Card_Typ_Num = RandomNum.Next(0, 4);
                int Card_Tmp_Num = Get_One_Card(Card_Typ_Num);
                Player_Cards.Add(All_Cards[Card_Tmp_Num]);
                Player_Cards_Score.Add(Card_Tmp_Num - Card_Typ_Num * 13);
                Give_Cards.Play();
                if (Player_Cards.Count > 2)
                {
                    Player_Cards.Remove(Player_Cards[0]);
                }
            }

            void Robot_Data()
            {
                int Card_Typ_Num = RandomNum.Next(0, 4);
                int Card_Tmp_Num = Get_One_Card(Card_Typ_Num);
                Robot_Cards.Add(All_Cards[Card_Tmp_Num]);
                Robot_Cards_Score.Add(Card_Tmp_Num - Card_Typ_Num * 13);
                Give_Cards.Play();
                if (Robot_Cards.Count > 2)
                {
                    Robot_Cards.Remove(Player_Cards[0]);
                }
            }

            int Get_One_Card(int Card_Typ_Num)
            {
                int Get_One_Card_Typ_Num = Card_Typ_Num;
                //Club     = 0
                //Diamonds = 1
                //Hearts   = 2
                //Spades   = 3
                if (Get_One_Card_Typ_Num == 0 && Card_Typ_Clubs.Count > 0)
                {
                    int Random_Card = RandomNum.Next(0, Card_Typ_Clubs.Count);
                    Tmp_Card = Card_Typ_Clubs[Random_Card];
                    int Return_Num = Tmp_Card;
                    Card_Typ_Clubs.Remove(Random_Card);

                    return Return_Num;
                }
                else if (Card_Typ_Clubs.Count == 0)
                {
                    Get_One_Card_Typ_Num++;
                }
                if (Get_One_Card_Typ_Num == 1 && Card_Typ_Diamonds.Count > 0)
                {
                    int Random_Card = RandomNum.Next(0, Card_Typ_Diamonds.Count);
                    Tmp_Card = Card_Typ_Diamonds[Random_Card];
                    int Return_Num = 13 + Tmp_Card;
                    Card_Typ_Diamonds.Remove(Random_Card);
                    return Return_Num;
                }
                else if (Card_Typ_Diamonds.Count == 0)
                {
                    Get_One_Card_Typ_Num++;
                }
                if (Get_One_Card_Typ_Num == 2 && Card_Typ_Hearts.Count > 0)
                {
                    int Random_Card = RandomNum.Next(0, Card_Typ_Hearts.Count);
                    Tmp_Card = Card_Typ_Hearts[Random_Card];
                    int Return_Num = 26 + Tmp_Card;
                    Card_Typ_Hearts.Remove(Random_Card);
                    return Return_Num;
                }
                else if (Card_Typ_Hearts.Count == 0)
                {
                    Get_One_Card_Typ_Num++;
                }
                if (Get_One_Card_Typ_Num == 3 && Card_Typ_Spades.Count > 0)
                {
                    int Random_Card = RandomNum.Next(0, Card_Typ_Spades.Count);
                    Tmp_Card = Card_Typ_Spades[Random_Card];
                    int Return_Num = 39 + Tmp_Card;
                    Card_Typ_Spades.Remove(Random_Card);
                    return Return_Num;
                }
                else if (Card_Typ_Spades.Count == 0)
                {
                    Get_One_Card_Typ_Num++;
                }
                return Get_One_Card(Get_One_Card_Typ_Num);
            }

            void Shuffle_Cards()
            {
                for (int i = 1; i < 14; i++)
                {
                    Card_Typ_Clubs.Add(i);
                }
                for (int i = 1; i < 14; i++)
                {
                    Card_Typ_Diamonds.Add(i);
                }
                for (int i = 1; i < 14; i++)
                {
                    Card_Typ_Hearts.Add(i);
                }
                for (int i = 1; i < 14; i++)
                {
                    Card_Typ_Spades.Add(i);
                }
                Shuffle.Play();
            }

            void Music_Choose()
            {
                switch (music_num)
                {
                    case 0:
                        MediaPlayer.Play(Music0);
                        break;
                    case 1:
                        MediaPlayer.Play(Music1);
                        break;
                    case 2:
                        MediaPlayer.Play(Music2);
                        break;
                    case 3:
                        MediaPlayer.Stop();
                        break;
                    default:
                        break;
                }
            }

            void Game_Page_Remove_All()
            {
                Game_Need_More_Card_Button_Position.Y += 1000;
                Game_Stop_Button_Position.Y += 1000;
            }

            void All_Game_Page_Back()
            {
                Game_Need_More_Card_Button_Position.Y -= 1000;
                Game_Stop_Button_Position.Y -= 1000;
            }

            void Options_Page_Remove_All()
            {
                Options_Page_Position.Y -= 1000;
                Options_Page_Close_Button_Position.Y -= 1000;
                Options_Page_Title_Position.Y -= 1000;
                Options_page_Music_change_Left_Button_Position.Y -= 1000;
                Options_page_Music_change_Right_Button_Position.Y -= 1000;
                Options_Page_Music_Display_Location_Position.Y -= 1000;
                Text_Music_Change_Position.Y -= 1000;
            }

            void All_Options_Page_Back()
            {
                Options_Page_Position.Y += 1000;
                Options_Page_Close_Button_Position.Y += 1000;
                Options_Page_Title_Position.Y += 1000;
                Options_page_Music_change_Left_Button_Position.Y += 1000;
                Options_page_Music_change_Right_Button_Position.Y += 1000;
                Options_Page_Music_Display_Location_Position.Y += 1000;
                Text_Music_Change_Position.Y += 1000;
            }



            void Initial_Page_Remove_All()
            {
                Text_Start_Position.Y -= 1000;
                Text_Options_Position.Y -= 1000;
                Game_Title_Position.Y -= 1000;
                Secend_Game_Title_Position.Y -= 1000;
                Start_Button_Position.Y -= 1000;
                Options_Button_Position.Y -= 1000;
                Title_Page_Position.Y -= 1000;
            }

            void All_Initial_Page_Back()
            {
                Text_Start_Position.Y += 1000;
                Text_Options_Position.Y += 1000;
                Game_Title_Position.Y += 1000;
                Secend_Game_Title_Position.Y += 1000;
                Start_Button_Position.Y += 1000;
                Options_Button_Position.Y += 1000;
                Title_Page_Position.Y += 1000;
            }

            // TODO: Add your update logic here
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            if (Initial_Page)
            {
                _spriteBatch.Draw(Title_Page, Title_Page_Position, Color.White);
                _spriteBatch.Draw(Start_Button, Start_Button_Position, Color.White);
                _spriteBatch.DrawString(Times_New_Roman_36, Text_Start, Text_Start_Position, Color.Black);
                _spriteBatch.Draw(Options_Button, Options_Button_Position, Color.White);
                _spriteBatch.DrawString(Times_New_Roman_36, Text_Options, Text_Options_Position, Color.Black);
                _spriteBatch.DrawString(Times_New_Roman_48, Game_Title, Game_Title_Position, Color.Black);
                _spriteBatch.DrawString(Times_New_Roman_36, Secend_Game_Title, Secend_Game_Title_Position, Color.Gray);
            }

            if (Game_Start)
            {
                _spriteBatch.Draw(Game_Background, Game_Background_Position, Color.White);
                _spriteBatch.Draw(Player_Cards[0], Player_Card_Position_1, Color.White);
                _spriteBatch.Draw(Player_Cards[1], Player_Card_Position_2, Color.White);
                _spriteBatch.Draw(Game_Player_Score_Display_Location, Game_Player_Score_Display_Location_Position, Color.White);
                _spriteBatch.DrawString(Times_New_Roman_48, PlayerScore.ToString(), Player_Score_Position, Color.Black);
                _spriteBatch.Draw(Game_Need_More_Card_Button, Game_Need_More_Card_Button_Position, Color.White);
                _spriteBatch.DrawString(Times_New_Roman_36, Text_Need_More_Card, Text_Need_More_Card_Position, Color.Black);
                _spriteBatch.Draw(Game_Stop_Button, Game_Stop_Button_Position,Color.White);
                _spriteBatch.DrawString(Times_New_Roman_36, Text_Stop, Text_Stop_Position, Color.Black);
                _spriteBatch.Draw(Robot_Cards[0], Robot_Card_Position_1, Color.White);
                _spriteBatch.Draw(Game_Robot_Score_Display_Location, Game_Robot_Score_Display_Location_Position, Color.White);
                _spriteBatch.Draw(Game_Options_Button, Game_Options_Button_Position, Color.White);
                if (RobotTurn)
                {
                    _spriteBatch.DrawString(Times_New_Roman_36, RobotScore.ToString(), Robot_Score_Position, Color.Black);
                    _spriteBatch.Draw(Robot_Cards[1], Robot_Card_Position_2, Color.White);
                }
                else
                {
                    _spriteBatch.DrawString(Times_New_Roman_36, "0", Robot_Score_Position, Color.Black);
                    _spriteBatch.Draw(All_Cards[53], Robot_Card_Position_2, Color.White);
                }
            }

            if (Options_Page_Open_Or_Close)
            {
                _spriteBatch.DrawString(Times_New_Roman_36, Options_Page_Title, Options_Page_Title_Position, Color.White);
                _spriteBatch.Draw(Options_Page, Options_Page_Position, Color.White);
                if (Grey_Or_Red)
                {
                    _spriteBatch.Draw(Options_Page_Close_Button_Grey, Options_Page_Close_Button_Position, Color.White);
                }
                else
                {
                    _spriteBatch.Draw(Options_Page_Close_Button_Red, Options_Page_Close_Button_Position, Color.White);
                }
                _spriteBatch.Draw(Options_Page_Music_Change_Left_Button, Options_page_Music_change_Left_Button_Position, Color.White);
                _spriteBatch.Draw(Options_Page_Music_Display_Location, Options_Page_Music_Display_Location_Position, Color.White);
                _spriteBatch.DrawString(Times_New_Roman_36, Text_Music_Change, Text_Music_Change_Position, Color.Black);
                _spriteBatch.Draw(Options_Page_Music_Change_Right_Button, Options_page_Music_change_Right_Button_Position, Color.White);
                if (Music_Open_Or_Close)
                {
                    _spriteBatch.Draw(Red_Cross, Options_Page_Music_Display_Location_Position, Color.White);
                }
            }

            if (Cursor_Or_Finger)
            {
                _spriteBatch.Draw(Mouse_Cursor, Mouse_Cursor_Position, Color.White);
            }
            else
            {
                _spriteBatch.Draw(Mouse_Finger, Mouse_Cursor_Position, Color.White);
            }

            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}