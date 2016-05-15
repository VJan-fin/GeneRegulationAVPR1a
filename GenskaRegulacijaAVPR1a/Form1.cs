using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenskaRegulacijaAVPR1a
{
    public partial class NucleusForm : Form
    {
        private static string tooltipMessage = "Кликни за повеќе информации";
        private string startText = "Целта на оваа анимација е да го прикаже процесот на генска експресија на генот AVPR1a. Тоа подразбира идентификување на молекулите кои претставуваат клучни актери во процесот, како и начинот на кој истите влегуваат во меѓусебна интеракција.\r\n\r\nЗа да може да започне целиот процес, најпрво е потребно RNA полимеразата да се поврзе со DNA молекулата на местото наречено TSS, односно почетно место на транскрипција.\r\nИзбери ги посакуваните вредности за транскрипциските фактори и за малите молекули и притисни ПОВРЗИ.";
        private string polymeraseMovingText = "RNA полимеразата е привлечена од DNA секвенцата која се наоѓа на почетното место на транскрипција, како резултат на голем број физички и хемиски привлечни сили. Тоа се нарекува афинитет.\r\n\r\nСлично, секој од транскрипциските фактори има своја секвенца од нуклеотиди која ја препознава и за која се поврзува. Овие секвенци на кои се поврзуваат регулаторните протеини се наоѓаат во промотор секвенцата.";
        private string transcriptionText = "За да може да започне транскрипцијата потребно е да има доволно позитивно влијание од транскрипциските фактори.\r\n\r\nИзбери ЗАПОЧНИ ТРАНСКРИПЦИЈА за да продолжи процесот и да видиш дали условите за експресија се исполнети.\r\nИзбери РЕСЕТИРАЈ доколку добиеш порака дека транскрипцијата не може да се случи. Промени ги параметрите и обиди се повторно.";
        private string transcriptionGoingText = "Избраната комбинација на транскрипциски фактори дозволува RNA полимеразата да се поврзе за DNA нишката. RNA полимеразата го чита генот и создава примарен транскрипт на mRNA според конкретниот шаблон. Количеството мали молекулски пертурбации влијае на брзината на транскрипцијата, а со тоа и на бројот на mRNA молекули кои ќе се синтетизираат.";

        public RNAPolymerase rnaPolymerase { get; set; }
        public Dictionary<string, TransciptionFactor> TFs { get; set; }
        public Dictionary<string, SmallMoleculePerturbation> smallMolecules { get; set; }

        private float mRNAQuantity = 0;

        public NucleusForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            LoadComponents();
            FillTexts();
            setScreenLayout();

            this.timeMoleculeBinding.Interval = this.timeRNATranscription.Interval = (int)this.rnaPolymerase.Speed;
        }

        public void LoadComponents()
        {

            this.lblProcessExplanation.BackColor = Color.FromArgb(144, 153, 186);

            // Animation control buttons
            this.btnStart.BackColor = this.btnStop.BackColor = this.btnReset.BackColor = Color.FromArgb(255, 139, 146, 174);
            this.btnStart.FlatAppearance.BorderColor = this.btnStop.FlatAppearance.BorderColor = this.btnReset.FlatAppearance.BorderColor = Color.FromArgb(255, 80, 85, 108);
            this.btnStart.FlatAppearance.BorderSize = this.btnStop.FlatAppearance.BorderSize = this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnStart.ForeColor = this.btnStop.ForeColor = this.btnReset.ForeColor = Color.White;


            // Necessary for proper and consistent change during mouse over
            this.lblTATA.FontSize = this.lblTSS.FontSize = this.lbl3UTR.FontSize = this.lbl5UTR.FontSize = this.lblUpstreamPromoter.FontSize = 11;
            this.lblGeneName.FontSize = 18;
            this.lblRNAPolymerase.FontSize = this.lblTF.FontSize = this.lblSmallMolecules.FontSize = 14;
            this.lblRP58.FontSize = this.lblXBP1.FontSize = this.lblE2F1.FontSize = this.lblCLOCK.FontSize = this.lblTRIM28.FontSize = 11;
            this.lblDiclofenamide.FontSize = this.lblLincomycin.FontSize = this.lblProcaine.FontSize = this.lblTroglitazone.FontSize = 11;


            // Setting a tooltip message that labels contain more details on click
            toolTip1.SetToolTip(this.lblTATA, tooltipMessage);
            toolTip1.SetToolTip(this.lblTSS, tooltipMessage);
            toolTip1.SetToolTip(this.lbl3UTR, tooltipMessage);
            toolTip1.SetToolTip(this.lbl5UTR, tooltipMessage);
            toolTip1.SetToolTip(this.lblGeneName, tooltipMessage);
            toolTip1.SetToolTip(this.lblRNAPolymerase, tooltipMessage);
            toolTip1.SetToolTip(this.lblTF, tooltipMessage);
            toolTip1.SetToolTip(this.lblSmallMolecules, tooltipMessage);
            toolTip1.SetToolTip(this.lblUpstreamPromoter, tooltipMessage);

            toolTip1.SetToolTip(this.lblRP58, tooltipMessage);
            toolTip1.SetToolTip(this.lblXBP1, tooltipMessage);
            toolTip1.SetToolTip(this.lblE2F1, tooltipMessage);
            toolTip1.SetToolTip(this.lblCLOCK, tooltipMessage);
            toolTip1.SetToolTip(this.lblTRIM28, tooltipMessage);

            toolTip1.SetToolTip(this.lblDiclofenamide, tooltipMessage);
            toolTip1.SetToolTip(this.lblLincomycin, tooltipMessage);
            toolTip1.SetToolTip(this.lblProcaine, tooltipMessage);
            toolTip1.SetToolTip(this.lblTroglitazone, tooltipMessage);
        }

        private void FillTexts()
        {
            this.lblProcessExplanation.Text = this.startText;

            this.lblTATA.ExplanationText = "Основниот промотор мора да биде присутен кај еукариотската DNA за да може RNA полимеразата да го започне процесот на транскрипција на генот.\r\n\r\nПромоторите се региони од DNA молекулата кои ја поддржуваат транскрипцијата, и кај еукариотите се наоѓаат на 30, 75 и 90 базни парови нагорно од местото за почеток на транскрипцијата (TSS = transcription start site). Најкарактеристичниот основен промотор во еукариотската DNA е познат како TATA кутија, поради неговата консензус секвенца, кој се наоѓа на 25-30 базни пара нагорно од TSS.\r\n\r\nВо основата на TATA кутијата е DNA секвенцата 5'-TATAAA-3' или некоја нејзина варијанта, која најчесто е проследена од три или повеќе аденин бази. Според истражувањата, оваа секвенца останала конзистентна и непроменета во текот на еволутивниот процес, а се верува дека потекнува од некој антички еукариотски организам.\r\n\r\nЗа да може воопшто да започне процесот на транскрипција, на TATA кутијата мора да се поврзат пет до седум транскрипциски фактори, заедно со RNA полимеразата, за да го формираат иницијалниот транскрипциски комплекс. За да се поедностави приказот на самиот процес, овие транскрипциски фактори кои влегуваат во состав на иницијалниот комплекс се изоставени во анимацијата.";
            this.lblTSS.ExplanationText = "Местото за почеток на транскрипција (TSS = transcription start site) е локацијата која се наоѓа на 5' крајот на DNA секвенцата, од каде што почнува транскрипцијата на генот.\r\n\r\nTSS е многу тешко да се најдат, особено што 5' UTR регионите не учествуваат во процесот на синтеза на крајниот протеин. Постојат лабораториски техники со кои може да се идентификува овој регион, но секако, тие не се апсолутно прецизни. Исто така, иако најголемиот број региони имаат точно еден TSS, некои гени имаат повеќе, па ги користат на строго регулиран начин. Општо, големиот број алтернативни транскрипти кои може да се добијат од еден ист ген го прават идентификувањето на TSS регионите проблематично.";
            this.lbl5UTR.ExplanationText = "Нетранслираниот регион (UTR = untranslated region) се однесува на една од двете секции кои се наоѓаат на секоја страна од кодирачката секвенца на генот, но и на mRNA нишката. Оној дел кој се наоѓа на 5' страната се нарекува 5' UTR или водич-секвенца, додека онаа што се наоѓа на 3' страната е 3' UTR или опашка-секвенца.\r\n\r\nНеколку региони од mRNA молекулите, меѓу кои и UTR регионите, не се преведуваат во протеини. Ова значи дека тие специфични делови се регулаторни, а не кодирачки, и не се читаат во кодони кои определуваат аминокиселини.\r\n\r\n5' UTR регионот се наоѓа нагорно од кодирачката секвенца. Во рамките на овој генски регион се наоѓа мотив кој е препознаен од страна на рибозомот. На таа конкретна секвенца се поврзува рибозомот и ја започнува транслацијата од mRNA во протеин.\r\n\r\nКај еукариотите 5' UTR регионот е покомплексен отколку кај прокариотите. Тој содржи таканаречена kozak консензус секвенца - ACCAUGG. Оваа секвенца го содржи почетниот кодон, кој е почетокот за транслација.";
            this.lbl3UTR.ExplanationText = "Нетранслираниот регион (UTR = untranslated region) се однесува на една од двете секции кои се наоѓаат на секоја страна од кодирачката секвенца на генот, но и на mRNA нишката. Оној дел кој се наоѓа на 5' страната се нарекува 5' UTR или водич-секвенца, додека онаа што се наоѓа на 3' страната е 3' UTR или опашка-секвенца.\r\n\r\nНеколку региони од mRNA молекулите, меѓу кои и UTR регионите, не се преведуваат во протеини. Ова значи дека тие специфични делови се регулаторни, а не кодирачки, и не се читаат во кодони кои определуваат аминокиселини.\r\n\r\n3' UTR регионот се наоѓа непосредно по стоп кодонот. Тој игра критична улога во прекинувањето на транслацијата, како и во пост-транкрипциската генска експресија.";
            this.lblUpstreamPromoter.ExplanationText = "Промотор е DNA регионот кој ја започнува транскрипцијата на конкретен ген. Промоторите се лоцирани блиску до местото на почеток на транскрипцијата, на истата нишка, нагоре кон 5' крајот. Нивната должина е најчесто помеѓу 100 и 1000 базни парови.\r\n\r\nБлизок промотор (proximal promoter) е регулаторна генска секвенца нагорно по DNA нишката која се наоѓа блиску до самиот ген. Се одликува со должина од приближно 250 базни парови и содржи специфични места на кои што се поврзуваат транскрипциските фактори.\r\n\r\nПокрај блиските промотори, постојат и т.н. далечни промотори (distal promoter), кои се која било регулаторна секвенца што содржи дополнителни места за врзување на транскрипциските фактори, а која се наоѓа подалеку од самиот ген. Вообичаено нивното влијание врз процесот на транскрипција е помало отколку на блискиот промотор.";

            this.lblGeneName.ExplanationText = "Аргинин вазопресин рецептор 1А (AVPR1a = arginine vasopressin receptor 1A) е еден од трите главни типови рецептори за аргинин вазопресин.\r\n\r\nВазопресин, уште познат и како антидиуретски хормон (ADH), е неврохипофизален хормон кој е присутен кај најголемиот број цицачи. Кај голем број видови содржи аргинин аминокиселина, од каде што доаѓа самото име на протеинот. Неговите две главни функции се задржувањето на водата во телото и стеснувањето (констрикцијата) на крвните садови.\r\n\r\nЧовековиот AVPR1a ген е сместен на дванаесеттиот хромозом, поточно на 12q14-15. cDNA секвенцата е долга 1472 базни пара и кодира полипептид со должина од 418 аминокиселини, кој што споделува 72%, 36%, 37% и 45% сличност со AVPR1a генот на стаорец, човековиот AVPR2, генот AVRP2 кај стаорец и човековиот рецептор за окситоцин (OXTR), соодветно.\r\n\r\nОвој рецептор кој е присутен во мозокот, перифериите на бубрезите, црниот дроб и крвните садови (васкулатурата), припаѓа на подфамилијата на G-protein coupled рецептори (GPCR) како што се AVPR1B, V2R и OXT. Неговата активност е посредувана од страна на G-протеините кои што го стимулираат phosphatidylinositol-calcium секундарниот систем за пораки во клетката.\r\n\r\nСпоред одредени проучувања, активноста и генетските варијации на овој ген се поврзани со љубезноста и алтруистичното однесување. NatureNews го нарекува AVPR1a „ген за безмилосност“. Студија од 2015 година наоѓа корелација помеѓу експресијата на овој ген и предиспозициите за вонбрачни врски кај жените, но не и кај мажите.";
            this.lblRNAPolymerase.ExplanationText = "RNA полимераза II е ензим кој се наоѓа во еукариотските клетки. Овој комплекс составен од 12 подединици, кој е најчесто проучуваниот тип RNA полимераза, го катализира (забрзува) процесот на транскрипција на DNA и на синтеза на примарен транскрипт на mRNA, како и на најголем дел snRNA и microRNA. Општо земено, RNA полимеразите се ензими кои се есенцијални за постоењето на животот и се наоѓаат кај сите организми, дури и кај многу вируси.\r\n\r\nПокрај RNA полимеразата II, потребен е и голем број транскрипциски фактори да бидат врзани за нагорниот генски промотор.";
            this.lblTF.ExplanationText = "Транскрипциски фактор (често наречени и DNA врзувачки фактори) е протеин кој се врзува со конкретна DNA секвенца и со тоа врши контрола на интензитетот на транскрипција на генетските информации од DNA во mRNA. Транскрипциските фактори ја вршат оваа улога самостојно или градејќи комплекс со други протеини. Имено, овие регулаторни протеини може да бидат активатори, што ја поттикнуваат транскрипцијата, или репресори, што го намалуваат интензитетот или комплетно го блокираат процесот на експресија на генот. Спречувањето на препишувањето на DNA материјалот во mRNA најчесто се прави на тој начин што комплексот од транскрипциски фактори оневозможува RNA полимеразата да се поврзе на TSS (transcription start site) и да го започне читањето.\r\n\r\nГлавниот елемент од кој се состојат сите транскрипциски фактори е DNA врзувачкиот домент (DNA-binding domain), кој се поврзува на точно определен DNA регион (мотив), блиску до самиот ген кој што е регулиран. Зависно од природата на самиот транскрипциски фактор, експресијата на генот може да биде зголемена или намалена, или целосно спречена.\r\n\r\nГенот AVPR1a има дузина различни транскрипциски фактори кои дејствуваат позитивно (активатори) или негативно (репресори) на неговата рата на транскрипција. За оваа анимација беа одбрани најрелевантните, односно оние со најголемо влијание, согласно CHEA Transcription Factor Targets податочното множество. За секој од овие транскрипциски фактори има доказ дека секвенцата за кој се поврзува се наоѓа во промоторот на генот.";
            this.lblSmallMolecules.ExplanationText = "Мала молекула е органско соединение кое има мала молекулска тежина (атомска маса помала од 900 далтони). Тие помагаат во регулацијата на биолошките процеси. Најголем дел од лековите претставуваат мали молекули. Малите молекулски пертурбации ја менуваат експресијата на AVPR1a генот.\r\n\r\nПертурбациите претставуваат одредени девијации или промени во системот, како резултат на секундарни влијанија, на пример влијанието на еден електрон во атомот на други.\r\n\r\nИнформациите кои се користени во оваа анимација потекнуваат од CMAP Signatures of Differentially Expressed Genes for Small Molecules податочното множество. Поради поедноставување на анимацијата, дадени се само неколку мали молекулски пертурбации чие присуство во клетката може да биде променето од страна на корисникот.";

            this.lblRP58.ExplanationText = "РЕПРЕСОР\r\n\r\nМотив за поврзување: GACCACATCTGGA\r\n\r\nRP58 (restriction protein 58), како што означува и самото име, дејствува како репресорен протеин на транскрипцијата на AVPR1a генот. Се покажало дека овој транскрипциски фактор се поврзува на промотор регионот на генот.";
            this.lblXBP1.ExplanationText = "АКТИВАТОР\r\n\r\nМотив за поврзување: TCCAGGTCACGTAGGCAC\r\n\r\nX-box binding protein 1, познат уште и како XBP1, е протеин кој кај луѓето е кодиран од истоимениот ген. Тој е лоциран на хромозомот број 22. Најчесто се јавува како транскрипциски фактор кај гени кои се важни за правилното функционирање на имунолошкиот систем и одговор на клетката на стрес.";
            this.lblE2F1.ExplanationText = "АКТИВАТОР\r\n\r\nМотив за поврзување: CTTGGCCCGGGAAATG\r\n\r\nОвој протеин е кодиран од ген кој припаѓа на E2F генската фамилија. Игра важна улога во контролата на клеточниот циклус и дејствува како тумор супресор. Сите протеини од E2F фамилијата имаат неколку конзервирани домени, од кои едниот е оној неопходен за поврзување на протеините со DNA нишката.";
            this.lblCLOCK.ExplanationText = "АКТИВАТОР\r\n\r\nМесто на поврзување: CLOCK-20551151-293T-HUMAN\r\n\r\nCLOCK (Circadian Locomotor Output Cycles Kaput) е ген кој кодира транскрипциски фактор кој влијае на истрајноста и на периодот на циркадијалниот ритам (биолошки процеси поврзани со т.н. биолошки часовник). CLOCK дејствува како активатор на гените кои се наоѓаат надолно на DNA нишката од местото каде тој се врзува.";
            this.lblTRIM28.ExplanationText = "РЕПРЕСОР\r\n\r\nМесто на поврзување: TRIM28-17542650-NTERA2-HUMAN\r\n\r\nTripartite motif-containing 28 (TRIM28) е протеин кој кај луѓето е кодиран од страна на TRIM28 генот. Овој протеин може да ја регулира транскрипцијата на гените преку различни механизми, од кои многу се' уште се нејасни. Еден од начините на кои врши репресија е преку директно врзување со DNA нишката. Другиот пристап е преку интеракција со Kruppel асоцираната кутија, која е репресорен домен што се наоѓа на многу транскрипциски фактори.";
        }


        public void setScreenLayout()
        {
            LoadTranscriptionFactors();

            this.rnaPolymerase = new RNAPolymerase("РНК полимераза II", "Објаснување за полимеразата", true, 200,
                new Point(517, 248),
                new Point(this.lblTSSMark.Location.X - 30, this.lblTSSMark.Location.Y - 10),
                new Point(this.lblUTR3Mark.Location.X + this.lblUTR3Mark.Width, this.lblUTR3Mark.Location.Y - 10));

            this.LoadSmallMolecules();
        }

        public void LoadTranscriptionFactors()
        {
            float bindingSpeed = 200;
            this.TFs = new Dictionary<string, TransciptionFactor>();

            this.TFs.Add(this.cbRP58.Name, new TransciptionFactor("RP58", "", cbRP58.Checked, bindingSpeed, new Point(50, 320), -1, new Point(125, 507), Color.PaleVioletRed, 19));
            this.TFs.Add(this.cbXBP1.Name, new TransciptionFactor("XBP-1", "", cbXBP1.Checked, bindingSpeed, new Point(105, 320), 1, new Point(138, 502), Color.LemonChiffon, 22));
            this.TFs.Add(this.cbE2F1.Name, new TransciptionFactor("E2F-1", "", cbE2F1.Checked, bindingSpeed, new Point(160, 320), 1, new Point(166, 512), Color.LightBlue, 19));
            this.TFs.Add(this.cbCLOCK.Name, new TransciptionFactor("CLOCK", "", cbCLOCK.Checked, bindingSpeed, new Point(210, 320), 1, new Point(183, 517), Color.Lavender, 21));
            this.TFs.Add(this.cbTRIM28.Name, new TransciptionFactor("TRIM28", "", cbTRIM28.Checked, bindingSpeed, new Point(270, 320), -1, new Point(208, 509), Color.Khaki, 25));
        
        }

        public void LoadSmallMolecules()
        {
            float speed = 10;
            Rectangle smallMoleculePanel = new Rectangle(523, 366, 411, 100);
            this.smallMolecules = new Dictionary<string, SmallMoleculePerturbation>();

            this.numDiclofenamide.Value = 0;
            this.numLincomycin.Value = 0;
            this.numProcaine.Value = 0;
            this.numTroglitazone.Value = 0;

            this.smallMolecules.Add(this.numDiclofenamide.Name, new SmallMoleculePerturbation("D", "", true, speed, Color.Sienna, 12, smallMoleculePanel));
            this.smallMolecules.Add(this.numLincomycin.Name, new SmallMoleculePerturbation("L", "", true, speed, Color.Salmon, 12, smallMoleculePanel));
            this.smallMolecules.Add(this.numProcaine.Name, new SmallMoleculePerturbation("P", "", true, speed, Color.LightSkyBlue, 12, smallMoleculePanel));
            this.smallMolecules.Add(this.numTroglitazone.Name, new SmallMoleculePerturbation("T", "", true, speed, Color.Moccasin, 12, smallMoleculePanel));
        }

        /**
         * Draws the two DNA strands in the bottom of the screen
         */
        private void drawDNAStrand(Graphics g)
        {
            Bitmap bitmap = new Bitmap(Properties.Resources.dna_strand);
            g.DrawImage(bitmap, -5, 491, 529, 47);
            g.DrawImage(bitmap, 523, 488, 467, 47);
        }

        /**
         * Draws the labels for the different regions on the DNA strand
         */
        private void drawDNARegions(Graphics g)
        {
            SolidBrush brush;
            SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, 50, 50, 50));
            Control control;
            Font labels = new Font("Calibri", (float)11.5, FontStyle.Bold);
            PointF textLocation;
            int alphaValue = 190;

            // Proximal promotor
            brush = new SolidBrush(Color.FromArgb(alphaValue, Color.DarkSeaGreen)); // RGB(143, 188, 143)
            control = this.lblPromotorMark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 10, control.Location.Y + control.Height / 3);
            g.DrawString("Близок промотор", labels, textBrush, textLocation);
        
            // TATA box
            brush = new SolidBrush(Color.FromArgb(alphaValue, 255, 192, 255));
            control = this.lblTATAMark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 12, control.Location.Y + control.Height / 3);
            g.DrawString("TATA", labels, textBrush, textLocation);

            // Transcription Start Site (TSS)
            brush = new SolidBrush(Color.FromArgb(alphaValue, 192, 255, 192));
            control = this.lblTSSMark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 10, control.Location.Y + control.Height / 3);
            g.DrawString("TSS", labels, textBrush, textLocation);

            // Untranslated region 5'
            brush = new SolidBrush(Color.FromArgb(alphaValue, 255, 192, 128));
            control = this.lblUTR5Mark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 4, control.Location.Y + control.Height / 3);
            g.DrawString("5' UTR", labels, textBrush, textLocation);

            // Exon 1
            brush = new SolidBrush(Color.FromArgb(alphaValue, 192, 192, 255));
            control = this.lblExon1Mark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 5, control.Location.Y + control.Height / 3);
            g.DrawString("Егзон 1", labels, textBrush, textLocation);

            // Intron 1
            brush = new SolidBrush(Color.FromArgb(alphaValue, 255, 128, 128));
            control = this.lblIntron1Mark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 5, control.Location.Y + control.Height / 3);
            g.DrawString("Интрон 1", labels, textBrush, textLocation);

            // Exon 2
            brush = new SolidBrush(Color.FromArgb(alphaValue, 192, 192, 255));
            control = this.lblExon2Mark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 12, control.Location.Y + control.Height / 3);
            g.DrawString("Егзон 2", labels, textBrush, textLocation);

            // Untranslated region 3'
            brush = new SolidBrush(Color.FromArgb(alphaValue, 255, 192, 128));
            control = this.lblUTR3Mark;
            g.FillRectangle(brush, control.Location.X, control.Location.Y, control.Width, control.Height);
            textLocation = new PointF(control.Location.X + control.Width / 4, control.Location.Y + control.Height / 3);
            g.DrawString("3' UTR", labels, textBrush, textLocation);
        
        }

        /**
         * Returns true if the transcription of the gene can begin,
         * false otherwise
         */
        private bool checkInfluence()
        {
            List<TransciptionFactor> tmp = new List<TransciptionFactor>(this.TFs.Values.Where<TransciptionFactor>(x => x.Visibility && x.IsAttached));
            if (tmp.Count == 0)
            {
                MessageBox.Show("Транскрипцијата не може да започне бидејќи нема транскрипциски фактори поврзани за промоторот");
                return false;
            }

            int influence = 0;
            foreach (var item in tmp)
            {
                influence += item.Influence;
            }

            if (influence == 0)
            {
                MessageBox.Show("Транскрипцијата не може да започне бидејќи нема доволно активатори кои придонесуваат со своето позитивно влијание");
                return false;
            }
            else if (influence < 0)
            {
                MessageBox.Show("Транскрипцијата не може да започне бидејќи има повеќе репресори отколку активатори на промотор секвенцата. Овие репресори ја спречуваат експресијата на генот.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ClickableLabel_Click(object sender, EventArgs e)
        {
            ClickableLabel customLabel = sender as ClickableLabel;
            customLabel.showExplanation();
        }

        private void ClickableLabel_MouseEnter(object sender, EventArgs e)
        {
            ClickableLabel customLabel = sender as ClickableLabel;
            customLabel.ForeColor = ClickableLabel.FocusTextColour;
            customLabel.Font = new Font("Calibri", customLabel.FontSize, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
        }

        private void ClickableLabel_MouseLeave(object sender, EventArgs e)
        {
            ClickableLabel customLabel = sender as ClickableLabel;
            customLabel.ForeColor = ClickableLabel.NormalTextColour;
            customLabel.Font = new Font("Calibri", customLabel.FontSize, FontStyle.Regular);
            this.Cursor = Cursors.Default;
        }

        private void timeMoleculeBinding_Tick(object sender, EventArgs e)
        {
            this.rnaPolymerase.move();
            if (this.rnaPolymerase.IsAttached)
            {
                this.btnStart.Text = "Започни транскрипција";
                this.lblProcessExplanation.Text = this.transcriptionText;
                this.btnStart.Enabled = true;
                this.rnaPolymerase.IsMoving = false;
                this.timeMoleculeBinding.Stop();
            }

            foreach (var item in this.TFs.Values)
            {
                item.move();
            }
            Invalidate();
        }

        private void timeRNATranscription_Tick(object sender, EventArgs e)
        {
            this.rnaPolymerase.move();
            if (this.rnaPolymerase.CurrentPosition == this.rnaPolymerase.InitialPosition)
            {
                this.btnStart.Text = "Поврзи";
                this.lblProcessExplanation.Text = this.startText;
                this.btnStart.Enabled = true;
                this.timeRNATranscription.Stop();

                //mRNA synthesis text
                this.lblRNAQuantity.Text = "+ " + (1 + (int)(this.mRNAQuantity / 3)).ToString() + " mRNA";
                this.lblRNAQuantity.Visible = true;
                this.lblNextPhase.Visible = true;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.drawDNAStrand(e.Graphics);
            this.drawDNARegions(e.Graphics);

            this.rnaPolymerase.Draw(e.Graphics);

            // draw the TF representations
            foreach (var item in this.TFs.Values)
            {
                item.Draw(e.Graphics);
            }

            // draw the small molecules representations
            foreach (var item in this.smallMolecules.Values)
            {
                item.Draw(e.Graphics);
            }

        }

        private void NucleusForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "Поврзи")
            {
                this.lblProcessExplanation.Text = this.polymeraseMovingText;
                this.timeMoleculeBinding.Start();
                btn.Enabled = false;
                this.rnaPolymerase.IsMoving = true;
                foreach (var item in this.TFs.Values)
                {
                    item.IsMoving = true;
                }
            }
            else if (btn.Text == "Започни транскрипција")
            {
                this.lblProcessExplanation.Text = this.transcriptionGoingText;
                bool canTranscribe = this.checkInfluence();
                if (canTranscribe)
                {
                    btn.Enabled = false;
                    this.rnaPolymerase.IsMoving = true;
                    this.timeRNATranscription.Start();
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.lblProcessExplanation.Text = "Избери " + this.btnStart.Text + " за да продолжи процесот.";
            this.timeMoleculeBinding.Stop();
            this.timeRNATranscription.Stop();
            this.rnaPolymerase.IsMoving = false;
            this.btnStart.Enabled = true;
            foreach (var item in this.TFs.Values)
            {
                item.IsMoving = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.setScreenLayout();
            this.btnStart.Text = "Поврзи";
            this.btnStart.Enabled = true;
            this.timeMoleculeBinding.Stop();
            this.timeRNATranscription.Stop();
            this.rnaPolymerase.Speed = 200;
            this.timeMoleculeBinding.Interval = this.timeRNATranscription.Interval = (int)this.rnaPolymerase.Speed;
            this.lblProcessExplanation.Text = this.startText;
            Invalidate();
        }

        private void cbTF_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            TransciptionFactor tf;
            if (this.TFs.ContainsKey(cb.Name))
            {
                tf = this.TFs[cb.Name];
                tf.Visibility = cb.Checked;
            }
            Invalidate();
        }

        private void numSmallMolecules_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown control = sender as NumericUpDown;
            if (this.smallMolecules.ContainsKey(control.Name))
            {
                int oldValue = this.smallMolecules[control.Name].Locations.Count;
                int newValue = (int)control.Value;
                if (oldValue < newValue)
                {
                    this.smallMolecules[control.Name].increaseSmallMoleculeQuantity();
                    this.mRNAQuantity += 0.5f;
                    this.rnaPolymerase.Speed -= this.smallMolecules[control.Name].Speed;
                }
                else if (oldValue > newValue)
                {
                    this.smallMolecules[control.Name].decreaseSmallMoleculeQuantity();
                    this.mRNAQuantity -= 0.5f;
                    this.rnaPolymerase.Speed += this.smallMolecules[control.Name].Speed;
                }

                this.timeMoleculeBinding.Interval = this.timeRNATranscription.Interval = (int)this.rnaPolymerase.Speed;
            }
            Invalidate();
        }

        private void lblRNAQuantity_Click(object sender, EventArgs e)
        {
            mRNAForm next = new mRNAForm();
            next.Show();
        }

        private void lblRNAQuantity_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblRNAQuantity_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
