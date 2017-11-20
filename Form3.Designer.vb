<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherEdit
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.MailDomain = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.MailLocal = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Emergency3 = New System.Windows.Forms.TextBox()
        Me.Contact3 = New System.Windows.Forms.TextBox()
        Me.Emergency1 = New System.Windows.Forms.TextBox()
        Me.Emergency2 = New System.Windows.Forms.TextBox()
        Me.Contact1 = New System.Windows.Forms.TextBox()
        Me.Contact2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Year = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Position = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.RoomNum = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BuildingName = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.HouseNum = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Zip2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Zip1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.City = New System.Windows.Forms.TextBox()
        Me.Prefecture = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Birthday = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FirstNameKana = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LastNameKana = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.GroupBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.Year, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.NameBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.OK)
        Me.GroupBox1.Controls.Add(Me.Cancel)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.NameBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 895)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'OK
        '
        Me.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OK.Location = New System.Drawing.Point(172, 837)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(103, 46)
        Me.OK.TabIndex = 8
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(367, 837)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(103, 46)
        Me.Cancel.TabIndex = 8
        Me.Cancel.Text = "キャンセル"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.MailDomain)
        Me.GroupBox8.Controls.Add(Me.Label25)
        Me.GroupBox8.Controls.Add(Me.MailLocal)
        Me.GroupBox8.Controls.Add(Me.Label24)
        Me.GroupBox8.Controls.Add(Me.Emergency3)
        Me.GroupBox8.Controls.Add(Me.Contact3)
        Me.GroupBox8.Controls.Add(Me.Emergency1)
        Me.GroupBox8.Controls.Add(Me.Emergency2)
        Me.GroupBox8.Controls.Add(Me.Contact1)
        Me.GroupBox8.Controls.Add(Me.Contact2)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Location = New System.Drawing.Point(14, 406)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(628, 142)
        Me.GroupBox8.TabIndex = 6
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "連絡先"
        '
        'MailDomain
        '
        Me.MailDomain.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.MailDomain.Location = New System.Drawing.Point(357, 92)
        Me.MailDomain.Name = "MailDomain"
        Me.MailDomain.Size = New System.Drawing.Size(162, 31)
        Me.MailDomain.TabIndex = 7
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(325, 95)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(26, 24)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "@"
        '
        'MailLocal
        '
        Me.MailLocal.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.MailLocal.Location = New System.Drawing.Point(74, 92)
        Me.MailLocal.Name = "MailLocal"
        Me.MailLocal.Size = New System.Drawing.Size(245, 31)
        Me.MailLocal.TabIndex = 6
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 95)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 24)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "メール"
        '
        'Emergency3
        '
        Me.Emergency3.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Emergency3.Location = New System.Drawing.Point(236, 57)
        Me.Emergency3.Name = "Emergency3"
        Me.Emergency3.Size = New System.Drawing.Size(49, 31)
        Me.Emergency3.TabIndex = 5
        '
        'Contact3
        '
        Me.Contact3.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Contact3.Location = New System.Drawing.Point(236, 24)
        Me.Contact3.Name = "Contact3"
        Me.Contact3.Size = New System.Drawing.Size(49, 31)
        Me.Contact3.TabIndex = 2
        '
        'Emergency1
        '
        Me.Emergency1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Emergency1.Location = New System.Drawing.Point(75, 57)
        Me.Emergency1.Name = "Emergency1"
        Me.Emergency1.Size = New System.Drawing.Size(49, 31)
        Me.Emergency1.TabIndex = 3
        '
        'Emergency2
        '
        Me.Emergency2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Emergency2.Location = New System.Drawing.Point(158, 57)
        Me.Emergency2.Name = "Emergency2"
        Me.Emergency2.Size = New System.Drawing.Size(49, 31)
        Me.Emergency2.TabIndex = 4
        '
        'Contact1
        '
        Me.Contact1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Contact1.Location = New System.Drawing.Point(75, 24)
        Me.Contact1.Name = "Contact1"
        Me.Contact1.Size = New System.Drawing.Size(49, 31)
        Me.Contact1.TabIndex = 0
        '
        'Contact2
        '
        Me.Contact2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Contact2.Location = New System.Drawing.Point(158, 24)
        Me.Contact2.Name = "Contact2"
        Me.Contact2.Size = New System.Drawing.Size(49, 31)
        Me.Contact2.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(213, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 24)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(213, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 24)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(135, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 24)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(135, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 24)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 24)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "緊急"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "日中"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.Year)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Location = New System.Drawing.Point(187, 297)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(154, 83)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "就職年度"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(123, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 24)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "年"
        '
        'Year
        '
        Me.Year.Location = New System.Drawing.Point(55, 29)
        Me.Year.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.Year.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(62, 31)
        Me.Year.TabIndex = 0
        Me.Year.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "西暦"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Position)
        Me.GroupBox6.Location = New System.Drawing.Point(14, 297)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(136, 83)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "役職"
        '
        'Position
        '
        Me.Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Position.FormattingEnabled = True
        Me.Position.Location = New System.Drawing.Point(7, 31)
        Me.Position.Name = "Position"
        Me.Position.Size = New System.Drawing.Size(121, 32)
        Me.Position.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.RoomNum)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.BuildingName)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.HouseNum)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Zip2)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Zip1)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.City)
        Me.GroupBox5.Controls.Add(Me.Prefecture)
        Me.GroupBox5.Location = New System.Drawing.Point(14, 573)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(620, 231)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "住所"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(211, 31)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 24)
        Me.Label23.TabIndex = 17
        Me.Label23.Text = "都道府県"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(349, 189)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 24)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "例：101"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 189)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 24)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "部屋番号"
        '
        'RoomNum
        '
        Me.RoomNum.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.RoomNum.Location = New System.Drawing.Point(87, 186)
        Me.RoomNum.Name = "RoomNum"
        Me.RoomNum.Size = New System.Drawing.Size(130, 31)
        Me.RoomNum.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(349, 152)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(154, 24)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "例：駅元マンション"
        '
        'BuildingName
        '
        Me.BuildingName.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.BuildingName.Location = New System.Drawing.Point(87, 149)
        Me.BuildingName.Name = "BuildingName"
        Me.BuildingName.Size = New System.Drawing.Size(256, 31)
        Me.BuildingName.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 24)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "建物名"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(349, 114)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 24)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "例：1-1-1"
        '
        'HouseNum
        '
        Me.HouseNum.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.HouseNum.Location = New System.Drawing.Point(87, 111)
        Me.HouseNum.Name = "HouseNum"
        Me.HouseNum.Size = New System.Drawing.Size(256, 31)
        Me.HouseNum.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 114)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 24)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "番地"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(349, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(170, 24)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "例：岡山市北区駅元町"
        '
        'Zip2
        '
        Me.Zip2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Zip2.Location = New System.Drawing.Point(109, 28)
        Me.Zip2.Name = "Zip2"
        Me.Zip2.Size = New System.Drawing.Size(49, 31)
        Me.Zip2.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(86, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 24)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "-"
        '
        'Zip1
        '
        Me.Zip1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Zip1.Location = New System.Drawing.Point(39, 28)
        Me.Zip1.Name = "Zip1"
        Me.Zip1.Size = New System.Drawing.Size(41, 31)
        Me.Zip1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 24)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "〒"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "市区町村"
        '
        'City
        '
        Me.City.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.City.Location = New System.Drawing.Point(87, 73)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(256, 31)
        Me.City.TabIndex = 3
        '
        'Prefecture
        '
        Me.Prefecture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Prefecture.FormattingEnabled = True
        Me.Prefecture.Items.AddRange(New Object() {"北海道", "青森県", "岩手県", "宮城県", "秋田県", "山形県", "福島県", "茨城県", "栃木県", "群馬県", "埼玉県", "千葉県", "東京都", "神奈川県", "新潟県", "富山県", "石川県", "福井県", "山梨県", "長野県", "岐阜県", "静岡県", "愛知県", "三重県", "滋賀県", "京都府", "大阪府", "兵庫県", "奈良県", "和歌山県", "鳥取県", "島根県", "岡山県", "広島県", "山口県", "徳島県", "香川県", "愛媛県", "高知県", "福岡県", "佐賀県", "長崎県", "熊本県", "大分県", "宮崎県", "鹿児島県", "沖縄県"})
        Me.Prefecture.Location = New System.Drawing.Point(291, 28)
        Me.Prefecture.Name = "Prefecture"
        Me.Prefecture.Size = New System.Drawing.Size(121, 32)
        Me.Prefecture.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Birthday)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 192)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(226, 80)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "生年月日"
        '
        'Birthday
        '
        Me.Birthday.Location = New System.Drawing.Point(7, 31)
        Me.Birthday.Name = "Birthday"
        Me.Birthday.Size = New System.Drawing.Size(200, 31)
        Me.Birthday.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Gender)
        Me.GroupBox3.Location = New System.Drawing.Point(248, 192)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(66, 80)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "性別"
        '
        'Gender
        '
        Me.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"男", "女"})
        Me.Gender.Location = New System.Drawing.Point(9, 32)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(47, 32)
        Me.Gender.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FirstNameKana)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.LastNameKana)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(309, 31)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(285, 133)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "フリガナ"
        '
        'FirstNameKana
        '
        Me.FirstNameKana.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.FirstNameKana.Location = New System.Drawing.Point(62, 81)
        Me.FirstNameKana.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.FirstNameKana.Name = "FirstNameKana"
        Me.FirstNameKana.Size = New System.Drawing.Size(214, 31)
        Me.FirstNameKana.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "メイ"
        '
        'LastNameKana
        '
        Me.LastNameKana.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.LastNameKana.Location = New System.Drawing.Point(62, 29)
        Me.LastNameKana.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.LastNameKana.Name = "LastNameKana"
        Me.LastNameKana.Size = New System.Drawing.Size(214, 31)
        Me.LastNameKana.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "セイ"
        '
        'NameBox
        '
        Me.NameBox.Controls.Add(Me.FirstName)
        Me.NameBox.Controls.Add(Me.Label2)
        Me.NameBox.Controls.Add(Me.LastName)
        Me.NameBox.Controls.Add(Me.Label1)
        Me.NameBox.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NameBox.Location = New System.Drawing.Point(14, 31)
        Me.NameBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.NameBox.Size = New System.Drawing.Size(285, 133)
        Me.NameBox.TabIndex = 0
        Me.NameBox.TabStop = False
        Me.NameBox.Text = "氏名"
        '
        'FirstName
        '
        Me.FirstName.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.FirstName.Location = New System.Drawing.Point(62, 81)
        Me.FirstName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(214, 31)
        Me.FirstName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "名"
        '
        'LastName
        '
        Me.LastName.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.LastName.Location = New System.Drawing.Point(62, 29)
        Me.LastName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(214, 31)
        Me.LastName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "姓"
        '
        'TeacherEdit
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(644, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "TeacherEdit"
        Me.Text = "保育士編集"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.Year, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.NameBox.ResumeLayout(False)
        Me.NameBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents FirstNameKana As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LastNameKana As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NameBox As System.Windows.Forms.GroupBox
    Friend WithEvents FirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LastName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Gender As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Birthday As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Prefecture As System.Windows.Forms.ComboBox
    Friend WithEvents City As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Position As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Year As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Zip1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Zip2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Emergency3 As System.Windows.Forms.TextBox
    Friend WithEvents Contact3 As System.Windows.Forms.TextBox
    Friend WithEvents Emergency2 As System.Windows.Forms.TextBox
    Friend WithEvents Contact2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents BuildingName As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents HouseNum As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents RoomNum As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Emergency1 As System.Windows.Forms.TextBox
    Friend WithEvents Contact1 As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents MailDomain As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents MailLocal As System.Windows.Forms.TextBox
End Class
