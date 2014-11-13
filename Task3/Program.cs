using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    public struct symbolStat
    {
        public char Symbol;
        public double Statistic;

        public symbolStat(char c, double d)
        {
            Symbol = c;
            Statistic = d;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
#region входные строки
            //вариант 1
            string s_rus = "ычжчйбч гзшзиб лвщъывчйбх лзйвызкйвов бгвфызтчйбх пвгквтйв люъчк лыбпцчичйбх йвпчмжбе швщъбтчйбм п вфцзщъб увклэяъчыйне ъчейвцвобм.п ызгцбийне щъызйзе кбыз лывпвшхъщх бщщцчшвпзйбх лв щвгшзйбя ъчейвцвобм б зцовыбъквп щжбпзйбх кйвтчщъпз бгвфызтчйбм. щ лвквсэя ызгцбийне зцовыбъквп бсюъ пвгквтйвщъэ ющувыбъэ щжбпзйбч лзйвызк, йч ъчыхх лыб ьъвк п ызгкчызе бгвфызтчйбх, чов вфсчм ьущлвгбабб б ызгйввфызгйне бщузтчйбхе лыб лывачшюыч щжбпзйбх.чщцб щшчцзъэ йчщувцэув щйбкувп щ вшйвм  ъвиуб б лывщъв ызгкчщъбъэ бе ыхшвк п двъвычшзуъвыч, ычгюцэъзъ вузгнпзчъщх йч юшвпцчъпвыбъчцэйнк, лвъвкю иъв фюшюъ пбшйн кчщъз щвчшбйчйбх въшчцэйне изщъчм щжбпзчквм лзйвызкн. лвцюибъэ узшын, увъвынч фн бшчзцэйв щвщънувпнпзцбщэ шыюо щ шыюовк, лызуъбичщуб йчычзцэйв, пчшэ йз бъвовпнм ычгюцэъзъ пцбхяъ ызгцбийнч дзуъвын, ъзубч узу: бгкчйчйбч вщпчсчйбх, бгкчйчйбч двующйвов ызщщъвхйбх вфрчуъбпз. двъвоызд квтчъ увйъывцбывпзъэ ъчейбую, йв йч лыбывшю. вичйэ изщъв лыб щрчкуч лзйвызк лвхпцхяъщх йчтчцзъчцэйнч фцбуб въ пвшйвм бцб гчыузцэйвм лвпчыейвщъб. лвьъвкю бщлвцэгюяъщх щлчабзцэйнч юъбцбън шцх щжбпзйбх двъвщйбкувп п лзйвызкйнч бгвфызтчйбх.щвпычкчййнч лывоызккйнч лывшюуън лвгпвцхяъ щвгшзпзъэ воывкйнч лзйвызкн, щвщъвхсбч въ йчщувцэубе шв йчщувцэубе щвъчй щйбкувп. шцх щвгшзйбх лзйвызкн щ пнщвувм шчъзцбгзабчм ъычфючъщх евывжзх влъбуз йз зллзызъч шцх лывпчшчйбх щрчкуб, з ъзу тч квсйзх пнибщцбъчцэйзх щъзйабх. лыб щвгшзйбб бгвфызтчйбм фвцэжвов ызгычжчйбх ъычфюяъщх воывкйнч квсйвщъб въ пнибщцбъчцэйвм щъзйабб, йз увъвывм лывбгпвшбъщх щфвыуз. щ ьъвм ачцэя ызгызфзънпзяъщх зцовыбъкн ющувычйбх щфвыуб.лвщувцэую пв пычкх щрчкуб ычобщъыбыючъщх кйвтчщъпв шзййне, щ ызгцбийнк лвцвтчйбчк п лывщъызйщъпч, пщч лывоызккн бщлвцэгюяъ зцовыбъкн пнщъызбпзйбх бгвфызтчйбм п йютйвк лвыхшуч. гзъчк щцчшючъ лвщъывчйбч щчъуб бг увйъывцэйне ъвичу. вщйвпйзх лывфцчкз лыб пнщъызбпзйбб бгвфызтчйбм п «йзцвтчйбб» узшывп шыюо йз шыюоз. ичк щбцэйчч йзуцзшнпзчъщх узшы, ъчк кчйэжч пчывхъйвщъэ вжбфуб лыб лвщъывчйбб щчъуб увйъывцэйне ъвичу.йвпчмжбк ьъзлвк ызгпбъбх щбщъчк щвгшзйбх лзйвызкйне щйбкувп хпцхяъщх щбщъчкн ычобщъызабб бгвфызтчйбх щ йчщувцэубе узкчы. ъзу тч лвцюибцв ызщлывщъызйчйбч бщлвцэгвпзйбч жбывувюовцэйне вфрчуъбпвп. ьъв лвгпвцхчъ щвуызъбъэ увцбичщъпв двъвщйбкувп, йв юпчцбибпзчъ лывфцчкю бщузтчйбм б еывкзъбичщубе зфчыызабм. ";
            string s_eng = "isq wnxqvcqc dyt pyci cydifhtq htq uqcnzvqu iy ihbq hfhj jyat dtqquyp iy cshtq hvu xshvzq ni.  lj xyvithci, isq zva zqvqthw ealwnx wnxqvcq nc nviqvuqu iy zahthviqq jyat dtqquyp iy cshtq hvu xshvzq dtqq cydifhtq--iy phbq catq isq cydifhtq nc dtqq dyt hww nic acqtc.  isnc zqvqthw ealwnx wnxqvcq heewnqc iy pyci yd isq dtqq cydifhtq dyavuhinyv'c cydifhtq hvu iy hvj yisqt etyzthp fsycq haisytc xyppni iy acnvz ni.  (cypq yisqt dtqq cydifhtq dyavuhinyv cydifhtq nc xykqtqu lj isq zva wnlthtj zqvqthw ealwnx wnxqvcq nvciqhu.)  jya xhv heewj ni iy jyat etyzthpc, iyy.   fsqv fq ceqhb yd dtqq cydifhtq, fq htq tqdqttnvz iy dtqquyp, vyi etnxq.  yat zqvqthw ealwnx wnxqvcqc htq uqcnzvqu iy phbq catq ishi jya shkq isq dtqquyp iy uncitnlaiq xyenqc yd dtqq cydifhtq (hvu xshtzq dyt isnc cqtknxq nd jya fncs), ishi jya tqxqnkq cyatxq xyuq yt xhv zqi ni nd jya fhvi ni, ishi jya xhv xshvzq isq cydifhtq yt acq enqxqc yd ni nv vqf dtqq etyzthpc; hvu ishi jya bvyf jya xhv uy isqcq isnvzc.   iy etyiqxi jyat tnzsic, fq vqqu iy phbq tqcitnxinyvc ishi dytlnu hvjyvq iy uqvj jya isqcq tnzsic yt iy hcb jya iy cattqvuqt isq tnzsic. isqcq tqcitnxinyvc ithvcwhiq iy xqtihnv tqceyvcnlnwninqc dyt jya nd jya uncitnlaiq xyenqc yd isq cydifhtq, yt nd jya pyundj ni.   dyt qrhpewq, nd jya uncitnlaiq xyenqc yd caxs h etyzthp, fsqisqt zthinc yt dyt h dqq, jya paci znkq isq tqxnenqvic hww isq tnzsic ishi jya shkq.  jya paci phbq catq ishi isqj, iyy, tqxqnkq yt xhv zqi isq cyatxq xyuq.  hvu jya paci csyf isqp isqcq iqtpc cy isqj bvyf isqnt tnzsic.   fq etyiqxi jyat tnzsic fnis ify ciqec: (1) xyejtnzsi isq cydifhtq, hvu (2) yddqt jya isnc wnxqvcq fsnxs znkqc jya wqzhw eqtpnccnyv iy xyej, uncitnlaiq hvu/yt pyundj isq cydifhtq.   hwcy, dyt qhxs haisyt'c etyiqxinyv hvu yatc, fq fhvi iy phbq xqtihnv ishi qkqtjyvq avuqtcihvuc ishi isqtq nc vy fhtthvij dyt isnc dtqq cydifhtq.  nd isq cydifhtq nc pyundnqu lj cypqyvq qwcq hvu ehccqu yv, fq fhvi nic tqxnenqvic iy bvyf ishi fshi isqj shkq nc vyi isq ytnznvhw, cy ishi hvj etylwqpc nvityuaxqu lj yisqtc fnww vyi tqdwqxi yv isq ytnznvhw haisytc' tqeaihinyvc.  dnvhwwj, hvj dtqq etyzthp nc istqhiqvqu xyvcihviwj lj cydifhtq ehiqvic.  fq fncs iy hkynu isq uhvzqt ishi tquncitnlaiytc yd h dtqq etyzthp fnww nvunknuahwwj ylihnv ehiqvi wnxqvcqc, nv qddqxi phbnvz isq etyzthp etyetnqihtj.  iy etqkqvi isnc, fq shkq phuq ni xwqht ishi hvj ehiqvi paci lq wnxqvcqu dyt qkqtjyvq'c dtqq acq yt vyi wnxqvcqu hi hww.   isq etqxncq iqtpc hvu xyvuninyvc dyt xyejnvz, uncitnlainyv hvu pyundnxhinyv dywwyf.     zva zqvqthw ealwnx wnxqvcq    iqtpc hvu xyvuninyvc dyt xyejnvz, uncitnlainyv hvu pyundnxhinyv   0. isnc wnxqvcq heewnqc iy hvj etyzthp yt yisqt fytb fsnxs xyvihnvc h vyinxq ewhxqu lj isq xyejtnzsi sywuqt chjnvz ni phj lq uncitnlaiqu avuqt isq iqtpc yd isnc zqvqthw ealwnx wnxqvcq.  isq \"etyzthp\", lqwyf, tqdqtc iy hvj caxs etyzthp yt fytb, hvu h \"fytb lhcqu yv isq etyzthp\" pqhvc qnisqt isq etyzthp yt hvj uqtnkhinkq fytb avuqt xyejtnzsi whf: ishi nc iy chj, h fytb xyvihnvnvz isq etyzthp yt h eytinyv yd ni, qnisqt kqtlhinp yt fnis pyundnxhinyvc hvu/yt ithvcwhiqu nviy hvyisqt whvzahzq.  (sqtqnvhdiqt, ithvcwhinyv nc nvxwauqu fnisyai wnpnihinyv nv isq iqtp \"pyundnxhinyv\".)  qhxs wnxqvcqq nc huutqccqu hc \"jya\".";
            //вариант 2
            //string s_rus = "хчфг жйудо упвгупхр одфхкпръчт, ий мдяджги, врд ду ядфпргфху. чрпргчргог идмлр яйвгчфгръ ядфпргфъудчръ, жпччвгрпя мдздядх чрпузпжрудх дрофдухугх фдмпжгнип зухяуйб друдчгрхфъуйб гшихухугс ехуй (шпожйргт) кпшдядмд поргяп, (дцжхзхфхугх ядфпргфъудчрг я чфдяпжх яймфтзгр здчрпрдвуд чфдыуйи, уд я зпфъухсахи ух гчцдфъшлхрчт, г ухр ухдкбдзгидчрг хмд шпцдигупръ). цжг жпчвхрх эрдмд цпжпихржп ух зхфпхрчт жпшфгвгс ихызл одфхкпугтиг яяхжб г яугш, яд яугипугх цжгугипхрчт рдфъод пкчдфщрудх шупвхугх одфхкпугс еху. эрдр ухшупвгрхфъуйс, опшпфдчъ кй, нпор гиххр ожгргвхчодх шупвхугх. зхфд я рди, врд ячх лвпчругог жйуоп зхсчрялщр уп дчудяпугг чдкчряхууйб цждмудшдя упцжпяфхугт хмд зягыхугт. кдфъагучряд лвпчругодя жйуоп дцегдудя упкфщзпщр шп зягыхугхи ехуй кпшдядмд поргяп г, дчудяйяптчъ уп чядгб цжхзцдфдыхугтб, гчцдфъшлщр двхуъ цждчрлщ нджилфл, я дкьхи идыуд злипръ д ядфпргфъудчрг жйуоп опо д «одфхкпугтб жйуоп др шпожйргт о шпожйргщ». чльхчрялхр ржг ргцп ядфпргфъудчрг: - гчрджгвхчопт ядфпргфъудчръ — нпоргвхчопт ядфпргфъудчръ ехуй цждзлорп я рхвхугх дцжхзхфхуудмд гчрджгвхчодмд цхжгдзп яжхихуг; - дыгзпхипт — жйудвупт дехуоп ядфпргфъудчрг уп клзльхх; - дыгзпхипт гчрджгвхчопт - «фхрдцгчъ» цждмудшдя дыгзпхидс ядфпргфъудчрг.одмзп ий мдяджги д ядфпргфъудчрг, гчцдфъшлхидс я ехуддкжпшдяпугг дцегдудя, ий гиххи я ягзл дыгзпхилщ ядфпргфъудчръ. вхи яйах ядфпргфъудчръ (дыгзпхипт), рхи яйах апуч, врд дцегду клзхр «цжг зхуъмпб», г рхи здждых клзхр дцегду. я жпиопб рджмдяфг ядфпргфъудчръщ ржхсзхжй идмлръ дчльхчряфтръ цдолцол г цждзпыл ядфпргфъудчрг. хчфг гуяхчрдж гчцдфъшлхр чржпрхмгщ «цдолцог ядфпргфъудчрг», ду дыгзпхр чгфъудх зягыхугх ехуй кпшдядмд поргяп, упцжгихж поегг. я жпиопб эрдс чржпрхмгг цдолцпщрчт дцегдуй одфф г цлр, фгкд дзгу ягз дцегдудя шпихутхрчт чгурхргвхчог, уп цжпоргох лздкухх гчцдфъшдяпръ чгурхргол. ядшидыуй ухчодфъод япжгпурдя цдолцог ядфпргфъудчрг — эрд идмлр кйръ, упцжгихж, цдолцоп чржэззфп гфг чржэумфп. одмзп чльхчрялхр кдфъапт яхждтрудчръ рдмд, врд ехуп кпшдядмд поргяп ух гшихугрчт, фгкд гшихугрчт ухшупвгрхфъуд г чрдгидчръ дцегдудя шпяйахуп, гуяхчрдж идыхр чржпрхмгщ цждзпыг ядфпргфъудчрг. хчфг хмд дыгзпугт ух дцжпязпщрчт, рд идмлр ядшугоулръ дцжхзхфхууйх лкйрог. цжг дрчлрчрягг ядфпргфъудчрг уп жйуох гуяхчрдж цдфлвгр упгкдфъалщ цжгкйфъ.жпчвхр ядфпргфъудчрг дчльхчряфтхрчт зялит чцдчдкпиг. цхжяйс — гчцдфъшдяпугх дехуог уп дчудях жйудвуйб зпууйб — зпхр цдзжпшлихяпхилщ ядфпргфъудчръ. ярдждс ихрдз жпчвхрп ядфпргфъудчрг дчудяйяпхрчт уп гчцдфъшдяпугг гчрджгвхчогб зпууйб. ";
            //string s_eng = "mclrdrlrwu hlzwk lzma chsqrao, jrulkrxtlrha maj phjryrcmlrha mkw ahl chdwkwj xq lzru frcwauw; lzwq mkw htlurjw rlu uchsw.  lzw mcl hy ktaarao lzw skhokmp ru ahl kwulkrclwj, maj lzw htlstl ykhp lzw skhokmp ru chdwkwj hafq ry rlu chalwalu chaulrltlw m ihkb xmuwj ha lzw skhokmp (rajwswajwal hy zmdrao xwwa pmjw xq ktaarao lzw skhokmp). izwlzwk lzml ru lktw jwswaju ha izml lzw skhokmp jhwu. 1. qht pmq chsq maj jrulkrxtlw dwkxmlrp chsrwu hy lzw skhokmp'u uhtkcw chjw mu qht kwcwrdw rl, ra maq pwjrtp, skhdrjwj lzml qht chausrcthtufq maj msskhskrmlwfq stxfruz ha wmcz chsq ma msskhskrmlw chsqkrozl ahlrcw maj jrucfmrpwk hy imkkmalq; bwws ralmcl mff lzw ahlrcwu lzml kwywk lh lzru frcwauw maj lh lzw mxuwacw hy maq imkkmalq; maj ordw maq hlzwk kwcrsrwalu hy lzw skhokmp m chsq hy lzru frcwauw mfhao irlz lzw skhokmp. qht pmq czmkow m yww yhk lzw szqurcmf mcl hy lkmauywkkrao m chsq, majqht pmq ml qhtk hslrha hyywk imkkmalq skhlwclrha ra wnczmaow yhk m yww. 2. qht pmq phjryq qhtk chsq hk chsrwu hy lzw skhokmp hk maq shklrha hy rl, lztu yhkprao m ihkb xmuwj ha lzw skhokmp, maj chsq maj jrulkrxtlw utcz phjryrcmlrhau hk ihkb tajwk lzw lwkpu hy uwclrha 1 mxhdw, skhdrjwj lzml qht mfuh pwwl mff hy lzwuw chajrlrhau: m) qht ptul cmtuw lzw phjryrwj yrfwu lh cmkkq skhprawal ahlrcwu ulmlrao lzml qht czmaowj lzw yrfwu maj lzw jmlw hy maq czmaow. x) qht ptul cmtuw maq ihkb lzml qht jrulkrxtlw hk stxfruz, lzml ra izhfw hk ra smkl chalmrau hk ru jwkrdwj ykhp lzw skhokmp hk maq smkl lzwkwhy, lh xw frcwauwj mu m izhfw ml ah czmkow lh mff lzrkj smklrwu tajwk lzw lwkpu hy lzru frcwauw. c) ry lzw phjryrwj skhokmp ahkpmffq kwmju chppmaju ralwkmclrdwfq izwa kta, qht ptul cmtuw rl, izwa ulmklwj ktaarao yhk utcz ralwkmclrdw tuw ra lzw phul hkjramkq imq, lh skral hk jrusfmq ma maahtacwpwal racftjrao ma msskhskrmlw chsqkrozl ahlrcw maj m ahlrcw lzml lzwkw ru ah imkkmalq (hk wfuw, umqrao lzml qht skhdrjw m imkkmalq) maj lzml tuwku pmq kwjrulkrxtlw lzw skhokmp tajwk lzwuw chajrlrhau, maj lwffrao lzw tuwk zhi lh drwi m chsq hy lzru frcwauw.  (wncwslrha: ry lzw skhokmp rluwfy ru ralwkmclrdw xtl  jhwu ahl ahkpmffq skral utcz ma maahtacwpwal, qhtk ihkb xmuwj ha lzw skhokmp ru ahl kwetrkwj lh skral ma maahtacwpwal.) lzwuw kwetrkwpwalu mssfq lh lzw phjryrwj ihkb mu m izhfw.  ry rjwalryrmxfw uwclrhau hy lzml ihkb mkw ahl jwkrdwj ykhp lzw skhokmp, maj cma xw kwmuhamxfq chaurjwkwj rajwswajwal maj uwsmkmlw ihkbu ra lzwpuwfdwu, lzwa lzru frcwauw, maj rlu lwkpu, jh ahl mssfq lh lzhuw uwclrhau izwa qht jrulkrxtlw lzwp mu uwsmkmlw ihkbu.  xtl izwa qht jrulkrxtlw lzw umpw uwclrhau mu smkl hy m izhfw izrcz ru m ihkb xmuwj ha lzw skhokmp, lzw jrulkrxtlrha hy lzw izhfw ptul xw ha lzw lwkpu hy lzru frcwauw, izhuw swkpruurhau yhk hlzwk frcwauwwu wnlwaj lh lzw walrkw izhfw, maj lztu lh wmcz maj wdwkq smkl kwomkjfwuu hy izh ikhlw rl.lztu, rl ru ahl lzw ralwal hy lzru uwclrha lh cfmrp krozlu hk chalwul qhtk krozlu lh ihkb ikrllwa walrkwfq xq qht; kmlzwk, lzw ralwal ru lh wnwkcruw lzw krozl lh chalkhf lzw jrulkrxtlrha hy jwkrdmlrdw hk chffwclrdw ihkbu xmuwj ha lzw skhokmp. ra mjjrlrha, pwkw mookwomlrha hy mahlzwk ihkb ahl xmuwj ha lzw skhokmp irlz lzw skhokmp (hk irlz m ihkb xmuwj ha lzw skhokmp) ha m dhftpw hy m ulhkmow hk jrulkrxtlrha pwjrtp jhwu ahl xkrao lzw hlzwk ihkb tajwk lzw uchsw hy lzru frcwauw. 3. qht pmq chsq maj jrulkrxtlw lzw skhokmp (hk m ihkb xmuwj ha rl,tajwk uwclrha 2) ra hxvwcl chjw hk wnwctlmxfw yhkp tajwk lzw lwkpu hy uwclrhau 1 maj 2 mxhdw skhdrjwj lzml qht mfuh jh haw hy lzw yhffhirao: m) mcchpsmaq rl irlz lzw chpsfwlw chkkwushajrao pmczraw-kwmjmxfw uhtkcw chjw, izrcz ptul xw jrulkrxtlwj tajwk lzw lwkpu hy uwclrhau 1 maj 2 mxhdw ha m pwjrtp ctulhpmkrfq tuwj yhk uhylimkw ralwkczmaow; hk, x) mcchpsmaq rl irlz m ikrllwa hyywk, dmfrj yhk ml fwmul lzkww qwmku, lh ordw maq lzrkj smklq, yhk m czmkow ah phkw lzma qhtk chul hy szqurcmffq swkyhkprao uhtkcw jrulkrxtlrha, m chpsfwlw pmczraw-kwmjmxfw chsq hy lzw chkkwushajrao uhtkcw chjw, lh xw jrulkrxtlwj tajwk lzw lwkpu hy uwclrhau 1 maj 2 mxhdw ha m pwjrtp ctulhpmkrfq tuwj yhk uhylimkw ralwkczmaow; hk, c) mcchpsmaq rl irlz lzw rayhkpmlrha qht kwcwrdwj mu lh lzw hyywk lh jrulkrxtlw chkkwushajrao uhtkcw chjw.  (lzru mflwkamlrdw ru mffhiwj hafq yhk ahachppwkcrmf jrulkrxtlrha maj hafq ry qht kwcwrdwj lzw skhokmp ra hxvwcl chjw hk wnwctlmxfw yhkp irlz utcz ma hyywk, ra mcchkj irlz utxuwclrha x mxhdw.) lzw uhtkcw chjw yhk m ihkb pwmau lzw skwywkkwj yhkp hy lzw ihkb yhk pmbrao phjryrcmlrhau lh rl.  yhk ma wnwctlmxfw ihkb, chpsfwlw uhtkcw chjw pwmau mff lzw uhtkcw chjw yhk mff phjtfwu rl chalmrau, sftu maq muuhcrmlwj ralwkymcw jwyrarlrha yrfwu, sftu lzw uckrslu tuwj lh chalkhf chpsrfmlrha maj raulmffmlrha hy lzw wnwctlmxfw.  zhiwdwk, mu muswcrmf wncwslrha, lzw uhtkcw chjw jrulkrxtlwj awwj ahl racftjw maqlzrao lzml ru ahkpmffq jrulkrxtlwj (ra wrlzwk uhtkcw hk xramkq yhkp) irlz lzw pmvhk chpshawalu (chpsrfwk, bwkawf, maj uh ha) hy lzw hswkmlrao uqulwp ha izrcz lzw wnwctlmxfw ktau, tafwuu lzml chpshawal rluwfy mcchpsmarwu lzw wnwctlmxfw.";
            //вариант 3
            //string s_rus = "щ  зсдлъэд фцяб  цоцюъбк сня пбь  емйюсцдъ й  цяъцк  йюцсцъб йюмсэъъбжэ яцжмжэ, м й ясыфцк - яьэъъбж цяъцгюмлъбж еямъэдж зця цяъцк исбудк,  ъдйжцюсн ъм юц, аюц цъц зсэъмяьдлмьц ядйнюимж щьмядьчшдщ. эе щйдо гюэо еямъэк юцьчиц ящм яцжм пбьэ лэьбжэ: яцж, фяд  фцйюэъэшм \"ицъюэъдъюмьч\", ям йюцнвэк сняцж й ъэж юсмиюэс дфцсцщм, еъмждъэюбк йщцэжэ пьэъмжэ.  цйюмьчъцд щйд ьмщиэ, щзьцюч яц ющдсйицк. юсмиюэс  дфцсцщм  ицфям-юц  зсэъмяьдлмь щцсцъэъы,  э  ъм  щбщдйид  пбьм эецпсмлдъм щцсцъм,  ядслмвмн  щ  иьтщд пьэъ. щйд  ьмщиэ  цоцюъцфц сням  пбьэ жнйъбд, сбпъбд, м зця  ъэжэ едьдъъбд зцящмьб. емяъэд ящдсэ ьмщци щбоцяэьэ ъм цфсцжъбк  ящцс-жцъдюъбк,  ими  дфц  ъмебщмьэ  эеясдщьд.  ъм  ъдж  пбьэ юцлд цяъцгюмлъбд  жнйъбд,  лэщцсбпъбд  э нэаъбд  ьмщиэ,  м зцйсдяэъд--ящыогюмлъбк \"жцъдюъбк\"  юсмиюэс. щ емяъдк амйюэ ящцсм - сня  ймсмтуди й зцфсдпмжэ э иьмяцщбжэ, иэудщуэжэ зцьаэвмжэ исбй.     цоцюъбк  сня зцьыаэь  йщцд  ъмещмъэд  двд щ  юд  щсдждъм,  ицфям  еядйч смесдудъц пбьц юцсфцщмюч яэачт, зсэъцйэжцк зцяжцйицщъбжэ цоцюъэимжэ.     щздсдяэ  ьмщци, ъм зьцвмяэ, щяцьч  уэсцицфц юсцюымсм, йюцньэ здсдъцйъбд змьмюиэ   э   юцьзэьэйч   юцсфцщшб  й  ицсеэъмжэ  э   ждуимжэ,  ъмзцьъдъъбжэ щйдщцежцлъбжэ  зсцяыиюмжэ.  оцяэьэ цоцюъэиэ,  цпщдумъъбд  ыюимжэ, юдюдсимжэ, емкшмжэ. ы пмп эе ицсеэъ юцсамьэ фцьцщб иыс э шбзьню, щ ждуимо щэелмьэ зцсцйнюм,  ицюцсбо зсцямщшб, щбъэжмн эе ждуим,аюцпб  зцимемюч  зциызмюдьт,  ъдзсдждъъц зцяъэжмьэ  ъмя  фцьцщцк,  ядслм ем йщнемъъбд  емяъэд  ъцфэ.  ъм  жцйюцщцк  здсдя  змьмюимжэ  йъцщмьэ зэсцлъэиэ, пьэъъэиэ,  юцсфцщшб фсдаъдщэимжэ,  лмсдъъбжэ  ъм зцйюъцж  жмйьд. йпэюдъвэиэ смеьэщмьэ, зц ицздкид ем  йюмимъ,  фцснаэк йпэюдъч - ьтпэжбк  юцфям ждяцщбк ъмзэюци, йцфсдщмщуэк эещцеаэицщ э йьылмвэо,  емждсемщуэо щ оцьцяъбо  ьмщимо. ьдюцж  йпэюдъвэицщ  йждъньэ юцсфцщшб  ищмймжэ, э  ймжбк  ьтпэжбк эе ъэо  пбь фсыудщбк, эе  щмсдъбо  фсыу,  ицюцсбд  щ  жцадъцж  щэяд ьдлмьэ  яьн  зсцямлэ зэсмжэямжэ ъм ьцюимо, м ищмй адсзмьэ эе щдясм исылимжэ. жнйъбд э сбпъбд ьмщиэ йцйюцньэ эе  ящыо цюядьдъэк. щ  здсщцж ьдлмьц ъм зцьимо жнйц смеъбо йцсюцщ - яэач, иысб, фыйэ, эъядкиэ, змьдъбд зцсцйнюм яьн лмсицфц  э щ ьдянъбо  щмъъмо - пдьбд зцсцйнюм  яьн емьэщъцфц.  ъм истачно  зц йюдъмж пбьэ смещдумъб юыуэ пмсмуицщ э  зцдъъбо жцьцицж юдьню, м щдйч зцюцьци емъню  цицсцимжэ  щйдщцежцлъбо смеждсцщ э  зсэфцюцщьдъэк--ицзадъбо, щмсдъбо, зсцщдйъбо. щц щюцсцж  цюядьдъээ, юджъцж,  цйщдвдъъцж юцьчиц ящдсчт  щц ящцс, щэйдьэ ядйнюиэ жнйъбо  юыу. зця щйджэ ьмщимжэ -- зцящмьб. цоцюъбк  сня пбщмь цйцпдъъц  цлэщьдъъбж  здсдя  пцьчуэжэ  зсмеяъэимжэ.  и ьмщимж  зцяхделмьэ ъм юбйнаъбо сбймимо смйрсмъадъъбд иызаэоэ, э ем ъэжэ йьылмвэд щбъцйэьэ эе ьмщци ицсеэъб э иыьчиэ й  юцщмсцж  э йщмьэщмьэ эо  щ ймъэ.  э юцсаэю,  пбщмьц,  эе сцфцлъцфц  иыьчим  сняцж  й йцпцьчдк  уыпцк жэььэцъдсуэ  цицсци,  м  зцздсди ждящдлчдк зцьцйюэ ьдлэю зыяцщбк жцсцлдъбк цйдюс щц щйдк йщцдк исмйцюд.     эе зцящмьцщ  змоьц юыоьнюэъцк, м юцщмс ьдлмь ъм зцьимо  здсщцйцсюъбк. щ сбпъбо - ьыаумн сбпм, м щ жнйъбо - иысб, фыйэ, эъядкиэ, зцсцйнюм. цицьц зсэьмщим  оьцзцаыю,  смйощмьэщмтю  юцщмс  э  пдйздсдпцкъц   щсыю зсэимеаэиэ  щ  емймьдъъбо яцьфцзцьбо  зцяядщимо э емйицсыеьбо  рмсюыимо.  ъм зцнйд ы ъэо - шдьбк мййцсюэждъю  ъцлдк, ицюцсбд  аэйюнюйн юцьчиц  ъм ъцач. аэйюцюм пбьм еядйч ъд щ жцяд.     фьмщъбжэ зциызмюдьнжэ  пбьэ  зцщмсм ьыауэо юсмиюэсцщ  э  сдйюцсмъцщ, м емюдж  зцщмсм  пмсйиэд  э  иыздадйиэд,  оценкиэ-иызаэоэ  э иыомсиэ.  щйд гюц юцьиьцйч, юцсфцщмьцйч, йзцсэьц эе-ем ицздкиэ, м цоцюъцснядш смййбзмьйн здсдя зциызмюдьдж, змжнюын йщцк дяэъйющдъъбк ьцеыъф: \"ъд цпжмъдуч - ъд зсцямуч\".     пдяъцюм  зциызмьм щ змьмюимо э й ьцюицщ  ы смеъцйаэицщ зцйьдяъэд  йцсюм жнйм: сдпсм, зцяпдядсци, зцисцжиы, юсдпыоы э ядудщыт пмсмъэъы-цсябъиы. юцщмс ьыауэо ьмщци эж ъд зц имсжмъы, цъ яьн юдо, ц ицюцсбо двд фцфцьч йимемь: \"яьн юдо, ицюцсбд зцаэвд\". ъц  э юдо э  ясыфэо  зсцямщшб щ ьмщимо  э  зсцямщшб ъм ыьэшмо цяэъмицщц цпщдуэщмтю э  цпйаэюбщмтю, ъд  цюьэамн пдяъцфц цю пцфмюцфц, - гюц пбь йюмсбк цпбамк цоцюъцсняйиэо юцсфцщшдщ, ъдцзсцщдслэжц  ыщдсдъъбо -- \"ъд  цпжмъдуч -- ъд зсцямуч\".     цоцюъбк  сня щцйчжэядйнюбо фцяцщ ймжбж  ъмфьняъбж  цпсмецж зсдяйюмщьндю зсцюциць ймъэюмсъцфц цйжцюсм гюцфц щсдждъэ. цйжцюс ъмамьйн й жнйъбо ьмщци э жцъдюъцфц ящцсм. ";
            //string s_eng = "pyt viqebov, xp q bqcvmc oxgvmzv jylof myc bvtexc tyrqocr-ptvv tvfxzctxhlcxym yp cwv btystqe hr qoo cwyzv jwy tvgvxnv gybxvz fxtvgcor yt xmfxtvgcor cwtylsw ryl, cwvm cwv ymor jqr ryl gylof zqcxzpr hycw xc qmf cwxz oxgvmzv jylof hv cy tvptqxm vmcxtvor ptye fxzctxhlcxym yp cwv btystqe. xp qmr bytcxym yp cwxz zvgcxym xz wvof xmnqoxf yt lmvmpytgvqhov lmfvt qmr bqtcxgloqt gxtglezcqmgv, cwv hqoqmgv yp cwv zvgcxym xz xmcvmfvf cy qbbor qmf cwv zvgcxym qz q jwyov xz xmcvmfvf cy qbbor xm ycwvt gxtglezcqmgvz. xc xz myc cwv bltbyzv yp cwxz zvgcxym cy xmflgv ryl cy xmptxmsv qmr bqcvmcz yt ycwvt btybvtcr txswc goqxez yt cy gymcvzc nqoxfxcr yp qmr zlgw goqxez; cwxz zvgcxym wqz cwv zyov bltbyzv yp btycvgcxms cwv xmcvstxcr yp cwv ptvv zypcjqtv fxzctxhlcxym zrzcve, jwxgw xz xebovevmcvf hr blhoxg oxgvmzv btqgcxgvz.  eqmr bvybov wqnv eqfv svmvtylz gymctxhlcxymz cy cwv jxfv tqmsv yp zypcjqtv fxzctxhlcvf cwtylsw cwqc zrzcve xm tvoxqmgv ym gymzxzcvmc qbboxgqcxym yp cwqc zrzcve; xc xz lb cy cwv qlcwyt/fymyt cy fvgxfv xp wv yt zwv xz jxooxms cy fxzctxhlcv zypcjqtv cwtylsw qmr ycwvt zrzcve qmf q oxgvmzvv gqmmyc xebyzv cwqc gwyxgv. cwxz zvgcxym xz xmcvmfvf cy eqdv cwytylswor govqt jwqc xz hvoxvnvf cy hv q gymzvalvmgv yp cwv tvzc yp cwxz oxgvmzv. 8. xp cwv fxzctxhlcxym qmf/yt lzv yp cwv btystqe xz tvzctxgcvf xm gvtcqxm gylmctxvz vxcwvt hr bqcvmcz yt hr gybrtxswcvf xmcvtpqgvz, cwv ytxsxmqo gybrtxswc wyofvt jwy boqgvz cwv btystqe lmfvt cwxz oxgvmzv eqr qff qm viboxgxc svystqbwxgqo fxzctxhlcxym oxexcqcxym vigolfxms cwyzv gylmctxvz, zy cwqc fxzctxhlcxym xz bvtexccvf ymor xm yt qeyms gylmctxvz myc cwlz vigolfvf.  xm zlgw gqzv, cwxz oxgvmzv xmgytbytqcvz cwv oxexcqcxym qz xp jtxccvm xm cwv hyfr yp cwxz oxgvmzv. 9. cwv ptvv zypcjqtv pylmfqcxym eqr blhoxzw tvnxzvf qmf/yt mvj nvtzxymz yp cwv svmvtqo blhoxg oxgvmzv ptye cxev cy cxev.  zlgw mvj nvtzxymz jxoo hv zxexoqt xm zbxtxc cy cwv btvzvmc nvtzxym, hlc eqr fxppvt xm fvcqxo cy qfftvzz mvj btyhovez yt gymgvtmz. vqgw nvtzxym xz sxnvm q fxzcxmslxzwxms nvtzxym mlehvt.  xp cwv btystqe zbvgxpxvz q nvtzxym mlehvt yp cwxz oxgvmzv jwxgw qbboxvz cy xc qmf \"qmr oqcvt nvtzxym\", ryl wqnv cwv ybcxym yp pyooyjxms cwv cvtez qmf gymfxcxymz vxcwvt yp cwqc nvtzxym yt yp qmr oqcvt nvtzxym blhoxzwvf hr cwv ptvv zypcjqtv pylmfqcxym.  xp cwv btystqe fyvz myc zbvgxpr q nvtzxym mlehvt yp cwxz oxgvmzv, ryl eqr gwyyzv qmr nvtzxym vnvt blhoxzwvf hr cwv ptvv zypcjqtv pylmfqcxym.  10. xp ryl jxzw cy xmgytbytqcv bqtcz yp cwv btystqe xmcy ycwvt ptvv btystqez jwyzv fxzctxhlcxym gymfxcxymz qtv fxppvtvmc, jtxcv cy cwv qlcwyt cy qzd pyt bvtexzzxym.  pyt zypcjqtv jwxgw xz gybrtxswcvf hr cwv ptvv zypcjqtv pylmfqcxym, jtxcv cy cwv ptvv zypcjqtv pylmfqcxym; jv zyevcxevz eqdv vigvbcxymz pyt cwxz.  ylt fvgxzxym jxoo hv slxfvf hr cwv cjy syqoz yp btvzvtnxms cwv ptvv zcqclz yp qoo fvtxnqcxnvz yp ylt ptvv zypcjqtv qmf yp btyeycxms cwv zwqtxms qmf tvlzv yp zypcjqtv svmvtqoor. hvgqlzv cwv btystqe xz oxgvmzvf ptvv yp gwqtsv, cwvtv xz my jqttqmcr pyt cwv btystqe, cy cwv vicvmc bvtexccvf hr qbboxgqhov oqj.  vigvbc jwvm ycwvtjxzv zcqcvf xm jtxcxms cwv gybrtxswc wyofvtz qmf/yt ycwvt bqtcxvz btynxfv cwv btystqe \"qz xz\" jxcwylc jqttqmcr yp qmr dxmf, vxcwvt vibtvzzvf yt xeboxvf, xmgolfxms, hlc myc oxexcvf cy, cwv xeboxvf jqttqmcxvz yp evtgwqmcqhxoxcr qmf pxcmvzz pyt q bqtcxgloqt bltbyzv.  cwv vmcxtv txzd qz cy cwv alqoxcr qmf bvtpyteqmgv yp cwv btystqe xz jxcw ryl.  zwylof cwv btystqe btynv fvpvgcxnv, ryl qzzlev cwv gyzc yp qoo mvgvzzqtr zvtnxgxms, tvbqxt yt gyttvgcxym. xm my vnvmc lmovzz tvalxtvf hr qbboxgqhov oqj yt qstvvf cy xm jtxcxms jxoo qmr gybrtxswc wyofvt, yt qmr ycwvt bqtcr jwy eqr eyfxpr qmf/yt tvfxzctxhlcv cwv btystqe qz bvtexccvf qhynv, hv oxqhov cy ryl pyt fqeqsvz, xmgolfxms qmr svmvtqo, zbvgxqo, xmgxfvmcqo yt gymzvalvmcxqo fqeqsvz qtxzxms ylc yp cwv lzv yt xmqhxoxcr cy lzv cwv btystqe (xmgolfxms hlc myc oxexcvf cy oyzz yp fqcq yt fqcq hvxms tvmfvtvf xmqggltqcv yt oyzzvz zlzcqxmvf hr ryl yt cwxtf bqtcxvz yt q pqxoltv yp cwv btystqe cy ybvtqcv jxcw qmr ycwvt btystqez), vnvm xp zlgw wyofvt yt ycwvt bqtcr wqz hvvm qfnxzvf yp cwv byzzxhxoxcr yp zlgw fqeqsvz.";
            //вариант 4
            //string s_rus = "ощтяфуфллщд зжщлщушжф отщдоьтфлла слицшьфйглаф жщйфхилшч пфл ли улщюшф тшна ьщтиящт. эящшстщншьфйш ш эщьяфхшьфйш сишльфяфощтила т ощснилшш зыыфжьштлар уфрилшсущт, оэщощхлар сикшьшьг шр щь лфщъшниллар шсуфлфлшд пфл ш ушлшушсшящтиьг лфхйиющэяшчьлаф зжщлщушцфожшф эщойфноьтшч. т  нфчьфйглщоьш йехар жщуэилшд, хмнг ьщ шлтфоьшпшщллад ыщлн, йшхщ офйгрщсэящшстщншьфйг тофюни фоьг ышлилощтаф яшожш. щлш ущюмь хаьг отчсила о цфу мющнлщ: эящниъи эящшстфнфллщд эящнмжпшш, яшож щхфопфлштилшч тйщъфллщющ т жижшф—йшхщ ижьшта жиэшьийи, эщжмэжи ижьштщт. зьщ щслицифь, цьщ т рщнф отщфд нфчьфйглщоьш жщуэилшш, шлаф еяшншцфожшф ш ышсшцфожшф, йшпи оьийжштиеьоч о тфящчьлщоьге ьщющ, цьщ т яфсмйгьиьф отщшр щэфяипшд щлш эщймциь мхаьщж, йшхщ эяшхайг щжиъфьоч лф ьижщд, ли жщьщяме щлш яиооцшьатийш шс-си лфэяфнтшнфллщющ шсуфлфлшч пфл ли ьщь ижьшт, о жщьщяау эящтщншьоч щэфяипшч. яшож эяфнэщйиюифь жиж тщсущълщоьг эщьфяш, ьиж ш тщсущълщоьг ташюяаби, лщ йенш, т хщйгбшлоьтф оймцифт, лф ожйщлла ж яшожм, ш эщзьщум щлш ощюйиола щьжисиьгоч щь хщйгбфд эяшхайш яинш муфлгбфлшч яшожи эщьфяг. нйч зьщющ хайш ощснила эящшстщнлаф ышлилощтаф  шлоьямуфльа — ыщятияна, ыгецфяоа, щэпшщла, и щэфяипшш эщ олшъфлше яшожи о эщущкге зьшр нфяштиьштщт эщймцшйш листилшф рфнъшящтилшф. эщлчьшф рфнъшящтилшф лфтщсущълщ яиожяаьг хфс эщлчьшч яшожи. яшож зьщ – тфящчьлщоьг (мюящси) эщьфяш циоьш отщшр яфомяощт, лфнщэщймцфлшч нщрщнщт шйш эящшстфнфлшч нщэщйлшьфйглар яиорщнщт т яфсмйгьиьф щомкфоьтйфлшч щэяфнфйфллар ышлилощтар щэфяипшд. йехщд ижьшт, нфлфълад эщьщж шйш ышлилощтад шлоьямуфль эщнтфяъфл яшожм щхфопфлфлшч. зьш яшожш, ощюйиолщ щхкфэяшлчьщд жйиоошышжипшш, нфйчьоч т щолщтлщу ли пфлщтаф ш эящпфльлаф. щьнфйглщ ущълщ танфйшьг яшож лфтаэщйлфлшч жщльяижьлар щхчсиьфйгоьт (эщожщйгжм ышлилощтаф шлоьямуфльа эщ омьш чтйчеьоч жщльяижьиуш), лисатифуад жяфншьлау. ьижшу щхяисщу, рфнъшящтилшф – зьщ шоэщйгсщтилшф щнлщющ шлоьямуфльи нйч олшъфлшч яшожи, отчсиллщющ о лфхйиющэяшчьлау тйшчлшфу яалщцлар ыижьщящт ли пфлм нямющющ, отчсиллщющ о лшу шлоьямуфльи, шйш ли юфлфяшямфуаф шу нфлфълаф эщьщжш. щхацлщ эщн рфнъшящтилшфу эщлшуиеь эящоьщ оьяирщтилшф яшожи шсуфлфлшч пфла ижьшти, эящпфльлщд оьитжш шйш тийеьлщющ жмяои о эщущкге эящшстщнлар шлоьямуфльщт, тоф зьщ трщншь т эщлчьшф рфнъшящтилшф ышлилощтар яшожщт (эщожщйгжм омкфоьтмеь фкф нямюшф яшожш, лиэяшуфя щэфяипшщллаф).  ышлилощтад яшож – зьщ яшож, жщьщящум яалщцлад июфль эщнтфяюифьоч шс-си отщфд ситшошущоьш щь ьижшр яалщцлар ыижьщящт, жиж эящпфльлаф оьитжш, щхуфллаф жмяоа ш пфла ьщтиящт. хщйгбшлоьтщ ышлилощтар яшожщт ущюмь рфнъшящтиьгоч хйиющнияч лийшцше яистшьар ш зыыфжьштлар яалжщт, ли жщьщяар зьш яшожш эфяфяиоэяфнфйчеьоч уфънм мциоьлшжиуш. рфнъшящтилшф яшожщт щолщтилщ ли оьяиьфюшш  ушлшушсипшш лфъфйиьфйглар яшожщт, эщзьщум яфсмйгьиьщу щэфяипшш ущъфь чтйчьгоч ьижъф ш олшъфлшф эщьфлпшийглщд эяшхайш, эщожщйгжм эяшхайг, жиж шстфоьлщ, лирщншьоч т щхяиьлщд ситшошущоьш о яшожщу. фойш яилфф рфнъшящтилшф шоэщйгсщтийщог шожйецшьфйглщ нйч ушлшушсипшш пфлщтар яшожщт, ьщ т лиоьщчкфф тяфуч пфйге рфнъшящтилшч таоьмэифь лф олчьшф яшожщт, и шр щэьшушсипшч. ";
            //string s_eng = "ufqzezqzvy cqovm qoux fcglzxw, nzyqmzhiqzcx uxn acnzkzfuqzcx umv xcq fcevmvn hl qozy pzfvxyv; qovl umv ciqyznv zqy yfcgv.  qov ufq ck mixxzxw qov gmcwmua zy xcq mvyqmzfqvn, uxn qov ciqgiq kmca qov gmcwmua zy fcevmvn cxpl zk zqy fcxqvxqy fcxyqzqiqv u rcmj huyvn cx qov gmcwmua (zxnvgvxnvxq ck ouezxw hvvx aunv hl mixxzxw qov gmcwmua). rovqovm qouq zy qmiv nvgvxny cx rouq qov gmcwmua ncvy.  1. lci aul fcgl uxn nzyqmzhiqv evmhuqza fcgzvy ck qov gmcwmua'yycimfv fcnv uy lci mvfvzev zq, zx uxl avnzia, gmceznvn qouq lci fcxygzficiypl uxn uggmcgmzuqvpl gihpzyo cx vufo fcgl ux uggmcgmzuqv fcglmzwoq xcqzfv uxn nzyfpuzavm ck rummuxql; jvvg zxqufq upp qov xcqzfvy qouq mvkvm qc qozy pzfvxyv uxn qc qov uhyvxfv ck uxl rummuxql; uxn wzev uxl cqovm mvfzgzvxqy ck qov gmcwmua u fcgl ck qozy pzfvxyv upcxw rzqo qov gmcwmua. lci aul foumwv u kvv kcm qov golyzfup ufq ck qmuxykvmmzxw u fcgl, uxn lci aul uq lcim cgqzcx ckkvm rummuxql gmcqvfqzcx zx vtfouxwv kcm u kvv.   2. lci aul acnzkl lcim fcgl cm fcgzvy ck qov gmcwmua cm uxl gcmqzcx ck zq, qoiy kcmazxw u rcmj huyvn cx qov gmcwmua, uxn fcgl uxn nzyqmzhiqv yifo acnzkzfuqzcxy cm rcmj ixnvm qov qvmay ck yvfqzcx 1 uhcev, gmceznvn qouq lci upyc avvq upp ck qovyv fcxnzqzcxy:    u) lci aiyq fuiyv qov acnzkzvn kzpvy qc fumml gmcazxvxq xcqzfvy    yquqzxw qouq lci fouxwvn qov kzpvy uxn qov nuqv ck uxl fouxwv.    h) lci aiyq fuiyv uxl rcmj qouq lci nzyqmzhiqv cm gihpzyo, qouq zx    rocpv cm zx gumq fcxquzxy cm zy nvmzevn kmca qov gmcwmua cm uxl    gumq qovmvck, qc hv pzfvxyvn uy u rocpv uq xc foumwv qc upp qozmn    gumqzvy ixnvm qov qvmay ck qozy pzfvxyv.    f) zk qov acnzkzvn gmcwmua xcmauppl mvuny fcaauxny zxqvmufqzevpl    rovx mix, lci aiyq fuiyv zq, rovx yqumqvn mixxzxw kcm yifo    zxqvmufqzev iyv zx qov acyq cmnzxuml rul, qc gmzxq cm nzygpul ux    uxxcixfvavxq zxfpinzxw ux uggmcgmzuqv fcglmzwoq xcqzfv uxn u    xcqzfv qouq qovmv zy xc rummuxql (cm vpyv, yulzxw qouq lci gmceznv    u rummuxql) uxn qouq iyvmy aul mvnzyqmzhiqv qov gmcwmua ixnvm    qovyv fcxnzqzcxy, uxn qvppzxw qov iyvm ocr qc ezvr u fcgl ck qozy    pzfvxyv.  (vtfvgqzcx: zk qov gmcwmua zqyvpk zy zxqvmufqzev hiq    ncvy xcq xcmauppl gmzxq yifo ux uxxcixfvavxq, lcim rcmj huyvn cx    qov gmcwmua zy xcq mvbizmvn qc gmzxq ux uxxcixfvavxq.) qovyv mvbizmvavxqy uggpl qc qov acnzkzvn rcmj uy u rocpv.  zkznvxqzkzuhpv yvfqzcxy ck qouq rcmj umv xcq nvmzevn kmca qov gmcwmua, uxn fux hv mvuycxuhpl fcxyznvmvn zxnvgvxnvxq uxn yvgumuqv rcmjy zx qovayvpevy, qovx qozy pzfvxyv, uxn zqy qvmay, nc xcq uggpl qc qocyv yvfqzcxy rovx lci nzyqmzhiqv qova uy yvgumuqv rcmjy.  hiq rovx lci nzyqmzhiqv qov yuav yvfqzcxy uy gumq ck u rocpv rozfo zy u rcmj huyvn cx qov gmcwmua, qov nzyqmzhiqzcx ck qov rocpv aiyq hv cx qov qvmay ck qozy pzfvxyv, rocyv gvmazyyzcxy kcm cqovm pzfvxyvvy vtqvxn qc qov vxqzmv rocpv, uxn qoiy qc vufo uxn vevml gumq mvwumnpvyy ck roc rmcqv zq. qoiy, zq zy xcq qov zxqvxq ck qozy yvfqzcx qc fpuza mzwoqy cm fcxqvyq lcim mzwoqy qc rcmj rmzqqvx vxqzmvpl hl lci; muqovm, qov zxqvxq zy qc vtvmfzyv qov mzwoq qc fcxqmcp qov nzyqmzhiqzcx ck nvmzeuqzev cm fcppvfqzev rcmjy huyvn cx qov gmcwmua. zx unnzqzcx, avmv uwwmvwuqzcx ck uxcqovm rcmj xcq huyvn cx qov gmcwmua rzqo qov gmcwmua (cm rzqo u rcmj huyvn cx qov gmcwmua) cx u ecpiav ck u yqcmuwv cm nzyqmzhiqzcx avnzia ncvy xcq hmzxw qov cqovm rcmj ixnvm qov yfcgv ck qozy pzfvxyv.  3. lci aul fcgl uxn nzyqmzhiqv qov gmcwmua (cm u rcmj huyvn cx zq, ixnvm yvfqzcx 2) zx chsvfq fcnv cm vtvfiquhpv kcma ixnvm qov qvmay ck yvfqzcxy 1 uxn 2 uhcev gmceznvn qouq lci upyc nc cxv ck qov kcppcrzxw:     u) uffcaguxl zq rzqo qov fcagpvqv fcmmvygcxnzxw aufozxv-mvunuhpv    ycimfv fcnv, rozfo aiyq hv nzyqmzhiqvn ixnvm qov qvmay ck yvfqzcxy    1 uxn 2 uhcev cx u avnzia fiyqcaumzpl iyvn kcm yckqrumv zxqvmfouxwv; cm,    h) uffcaguxl zq rzqo u rmzqqvx ckkvm, eupzn kcm uq pvuyq qomvv    lvumy, qc wzev uxl qozmn gumql, kcm u foumwv xc acmv qoux lcim    fcyq ck golyzfuppl gvmkcmazxw ycimfv nzyqmzhiqzcx, u fcagpvqv    aufozxv-mvunuhpv fcgl ck qov fcmmvygcxnzxw ycimfv fcnv, qc hv    nzyqmzhiqvn ixnvm qov qvmay ck yvfqzcxy 1 uxn 2 uhcev cx u avnzia    fiyqcaumzpl iyvn kcm yckqrumv zxqvmfouxwv; cm,    f) uffcaguxl zq rzqo qov zxkcmauqzcx lci mvfvzevn uy qc qov ckkvm    qc nzyqmzhiqv fcmmvygcxnzxw ycimfv fcnv.  (qozy upqvmxuqzev zy    uppcrvn cxpl kcm xcxfcaavmfzup nzyqmzhiqzcx uxn cxpl zk lci    mvfvzevn qov gmcwmua zx chsvfq fcnv cm vtvfiquhpv kcma rzqo yifo    ux ckkvm, zx uffcmn rzqo yihyvfqzcx h uhcev.) qov ycimfv fcnv kcm u rcmj avuxy qov gmvkvmmvn kcma ck qov rcmj kcmaujzxw acnzkzfuqzcxy qc zq.  kcm ux vtvfiquhpv rcmj, fcagpvqv ycimfvfcnv avuxy upp qov ycimfv fcnv kcm upp acnipvy zq fcxquzxy, gpiy uxl uyycfzuqvn zxqvmkufv nvkzxzqzcx kzpvy, gpiy qov yfmzgqy iyvn qc fcxqmcp fcagzpuqzcx uxn zxyquppuqzcx ck qov vtvfiquhpv.  ocrvevm, uy u ygvfzup vtfvgqzcx, qov ycimfv fcnv nzyqmzhiqvn xvvn xcq zxfpinv uxlqozxw qouq zy xcmauppl nzyqmzhiqvn (zx vzqovm ycimfv cm hzxuml kcma) rzqo qov auscm fcagcxvxqy (fcagzpvm, jvmxvp, uxn yc cx) ck qov cgvmuqzxw ylyqva cx rozfo qov vtvfiquhpv mixy, ixpvyy qouq fcagcxvxq zqyvpk uffcaguxzvy qov vtvfiquhpv.";
#endregion
#region языковая статистика
            var stat_eng1 = new double[26] { 0.0675, 0.0149, 0.0425, 0.0403, 0.127, 0.0278, 0.0202, 0.0599, 0.0697, 0.0015, 0.0077, 0.0241, 0.0193, 0.0609, 0.0817, 0.0223, 0.001, 0.0751, 0.0633, 0.0906, 0.0276, 0.0098, 0.0197, 0.0015, 0.0236, 0.0007 };
            var stat_eng = new symbolStat[26];
            for (int i = 0; i < stat_eng.Length; i++)
                stat_eng[i] = new symbolStat((char)('A' + i), stat_eng1[i]);

            Sort(stat_eng);

            var stat_rus1 = new double[32] { 0.062, 0.0131, 0.038, 0.012, 0.0161, 0.062, 0.009, 0.018, 0.072, 0.01, 0.028, 0.035, 0.026, 0.0531, 0.09, 0.023, 0.045, 0.04, 0.053, 0.014, 0.003, 0.013, 0.004, 0.007, 0.006, 0.003, 0.001, 0.021, 0.016, 0.002, 0.00599, 0.025 };
            var stat_rus = new symbolStat[32];
            for (int i = 0; i < stat_rus.Length; i++)
                stat_rus[i] = new symbolStat((char)('А' + i), stat_rus1[i]);

            Sort(stat_rus);
#endregion
#region подсчет статистики входных строк
            var freq_rus = FreqRUS(s_rus);
            Sort(freq_rus);
            /*for (int i = 0; i < freq_rus.Length; i++)
                Console.Write("{0} - {1:0.0000}\t", freq_rus[i].Symbol, freq_rus[i].Statistic);
            Console.WriteLine();
            Console.WriteLine();*/

            var freq_eng = FreqENG(s_eng);
            Sort(freq_eng);
            /*
            for (int i = 0; i < freq_eng.Length; i++)
                Console.Write("{0} - {1:0.0000}\t", freq_eng[i].Symbol, freq_eng[i].Statistic);
            Console.WriteLine();
            Console.WriteLine();*/
#endregion
#region вывод(рус): символ исходного текста -> символ выходного текста

            for (int i = 0; i < freq_rus.Length; i++)
            {
                Console.WriteLine(freq_rus[i].Symbol + " -> " + stat_rus[i].Symbol);
            }
#endregion
#region вывод(рус) расшифрованного текста
            string s = "";

            for (int i = 0; i < s_rus.Length; i++)
            {
                if (s_rus.ToUpper()[i] >= 'А' & s_rus.ToUpper()[i] <= 'Я')
                    s = s + Convert.ToString(stat_rus[SearchI(freq_rus, s_rus[i])].Symbol);
                else
                    s = s + s_rus[i];
            }
            Console.WriteLine(s.ToLower());
            Console.WriteLine();

            /*s = s_rus;
            for (int i = 0; i < stat_eng.Length; i++)
            {
                s = s.Replace(freq_rus[i].Symbol, stat_rus[i].Symbol);
            }
            Console.WriteLine(s);
            Console.WriteLine();*/
            #endregion
#region вывод(eng): символ исходного текста -> символ выходного текста

            for (int i = 0; i < freq_eng.Length; i++)
            {
                Console.WriteLine(freq_eng[i].Symbol + " -> " + stat_eng[i].Symbol);
            }
#endregion
#region вывод(eng) расшифрованного текста
            string s_e = "";

            for (int i = 0; i < s_eng.Length; i++)
            {
                if (s_eng.ToUpper()[i] >= 'A' & s_eng.ToUpper()[i] <= 'Z')
                    s_e = s_e + Convert.ToString(stat_eng[SearchI(freq_eng, s_eng[i])].Symbol);
                else
                    s_e = s_e + s_eng[i];
            }
            Console.WriteLine(s_e.ToLower());
            Console.WriteLine();
#endregion
            Console.ReadKey();
        }

        static symbolStat[] FreqRUS(string s)
        {
            var resultRUS = new symbolStat['Я' - 'А' + 1];

            for (int i = 0; i < resultRUS.Length; i++)
                resultRUS[i] = new symbolStat((char)('А' + i), 0);

            foreach (var c in s.ToUpper())
                if ((c >= 'А') && (c <= 'Я'))
                {
                    resultRUS[c - 'А'].Statistic++;
                }
            for (int i = 0; i < resultRUS.Length; i++)
                resultRUS[i].Statistic /= s.Length;

            return resultRUS;
        }

        static symbolStat[] FreqENG(string s)
        {
            var resultENG = new symbolStat['Z' - 'A' + 1];

            for (int i = 0; i < resultENG.Length; i++)
                resultENG[i] = new symbolStat((char)('A' + i), 0);

            foreach (var c in s.ToUpper())
                if ((c >= 'A') && (c <= 'Z'))
                {
                    resultENG[c - 'A'].Statistic++;
                }
            for (int i = 0; i < resultENG.Length; i++)
                resultENG[i].Statistic /= s.Length;

            return resultENG;
        }

        static void Sort(symbolStat[] array)
        {
            var temp = new symbolStat();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j].Statistic < array[j - 1].Statistic)
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }

        static int SearchI(symbolStat[] array, char c)
        {
            string s = Convert.ToString(c);
            s = s.ToUpper();
            c = Convert.ToChar(s);
            int i = 0;
            for (i = 0; i < array.Length; i++)
            {
                if (array[i].Symbol == c) break;
            }
            return i;
        }

    }
}