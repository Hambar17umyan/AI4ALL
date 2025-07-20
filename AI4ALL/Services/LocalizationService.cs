using AI4ALL.Models;

namespace AI4ALL.Services;

public static class LocalizationService
{
    private static readonly Dictionary<string, string> en = new()
    {
        {"HomeTitle", "Welcome to AI4ALL – by EIF"},
        {"HomeHeroTagline", "AI4ALL opens doors to AI for everyone, empowering you to develop hands-on skills and see how AI is transforming industries."},
        {"HomeMissionTitle", "Our Mission"},
        {"HomeMissionText", "To democratize Artificial Intelligence education in Armenia, making it accessible, practical, and inspiring for all."},
        {"HomeWhyTitle", "Why Participate?"},
        {"HomeWhyText", "Gain real-world AI skills, connect with innovators, and join a vibrant community supported by EIF."},
        {"HomeNewsTitle", "Latest News & Events"},
        {"HomeNewsText", "Stay tuned for upcoming workshops, hackathons, and AI4ALL milestones."},
        {"HomeCta", "Join AI4ALL today!"},
        {"HomeEIFTitle", "About EIF"},
        {"HomeEIFText", "The Enterprise Incubator Foundation (EIF) is Armenia’s leading tech incubator, fostering innovation and high-tech growth."},

        {"ResourcesTitle", "Resources"},

        {"ChatbotTitle", "AI4ALL Assistant"},

        {"ContactTitle", "Contact Us"},
        {"ContactEmail", "Email"},
        {"ContactPhone", "Phone"},
        {"ContactFormName", "Your Name"},
        {"ContactFormEmail", "Your Email"},
        {"ContactFormMessage", "Your Message"},
        {"ContactFormSend", "Send Message"},
        {"ContactFormSuccess", "Thank you! Your message has been sent."},

        {"ContactFollowTitle", "Follow us on social media." },
        // About page
    {"AboutTitle", "About AI4ALL" },
    {"AboutHero", "Empowering Armenia’s Next Generation of AI Innovators" },
    {"AboutDescription", "AI4ALL is a flagship educational initiative of Armenia’s Enterprise Incubator Foundation (EIF), created to democratize access to cutting‑edge artificial intelligence knowledge and hands‑on experience. Through a blend of in‑person workshops, self‑paced online modules, and team‑based hackathons, AI4ALL empowers students and young professionals across Armenia—regardless of their prior programming background—to explore the foundations of machine learning, deep learning, computer vision, and natural language processing." },
    {"AboutStats", "Since its inception, AI4ALL has trained over 700 participants from more than 25 schools and universities, hosted 18 hackathons with more than 1,500 total participants, and launched a free video‑based learning portal featuring over 250 hours of AI coursework." },
    {"AboutCommunity", "AI4ALL cultivates a vibrant community: regional chapters in Yerevan, Gyumri, and Vanadzor hold regular meetups and demo days; an online forum hosts resource libraries, code samples, and peer‑to‑peer support; and quarterly hackathons challenge teams to propose AI‑driven solutions to real‑world problems." },
    {"AboutMentorship", "Each participant is paired with an EIF‑connected expert, offering personalized guidance on project design, data ethics, and career pathways." },
    {"AboutFuture", "Looking ahead, AI4ALL plans to expand into advanced domains—reinforcement learning, AI fairness and ethics, and scalable model deployment—forge alliances with global academic partners, and introduce micro‑internships within EIF’s network of high‑tech companies." },
    {"AboutGalleryTitle", "Gallery & Highlights" },
    {"AboutTimelineTitle", "Milestones" },
        {"About2023", "Community chapters in 3 cities, 250+ hours of video content, and international partnerships." },
        {"About2021", "Over 500 participants, 10+ hackathons, and new online modules." },
        {"About2019", "AI4ALL launches with first workshops and hackathons."   },

        {"HomeNav", "Home"},
        {"AboutNav", "About" },
        {"ContactNav", "Contact" },
        {"ResourcesNav", "Resources" },
        {"ChatBotWelcome", "Welcome to the AI4ALL Assistant page—your personal gateway to on‑demand help and information about our AI4ALL program! Although this page is still under active development, you can immediately try out our beta chatbot by clicking the small chat bubble icon located in the bottom right corner of your screen. Once you click the icon, a sleek chat window will slide up, allowing you to type questions or browse predefined prompts. Whether you’re curious about upcoming workshops, want to learn more about our curriculum modules, or need technical tips for working with Python and machine learning, the AI4ALL Assistant is here to guide you in real time.\r\n\r\nOur chatbot is powered by an open‑source conversational AI engine, enabling it to understand and respond to a wide range of inquiries—everything from logistics and scheduling details to conceptual explanations of neural networks and data preprocessing. As we continue to refine and expand the system, you may notice occasional quirks or placeholder responses; rest assured, you’re engaging with a beta version that’s constantly learning and improving. We encourage you to experiment by asking both broad questions (“What is computer vision?”) and specific ones (“How do I preprocess images for a convolutional neural network?”), and to share any feedback using the feedback link in the chat interface. Your insights will directly shape the future capabilities of our Assistant.\r\n\r\nBehind the scenes, our team is working tirelessly to integrate more advanced features: knowledge retrieval from our resource library, context‑aware follow‑up conversations, and multi‑language support in Armenian and English. In the meantime, feel free to explore, ask for examples, or request code snippets—all within the chat window. Thank you for helping us test this innovative tool; together, we’ll make the AI4ALL Assistant smarter, more accurate, and an indispensable companion on your AI learning journey." },
        {"ChatbotNav", "Chatbot" }
    };

    private static readonly Dictionary<string, string> hy = new()
    {
        {"HomeTitle", "Բարի Գալուստ AI4ALL – EIF"},
        {"HomeHeroTagline", "AI4ALL բացում է բոլորի դռները դեպի ԱԲ, օգնելով մարդկանց ստանալ պրակտիկ տաղանդ և տեսնել ինչպես է ԱԲ-ն թևակոխում արդյունաբերության տարբեր ճյուղեր։"},
        {"HomeMissionTitle", "Մեր նպատակն է"},
        {"HomeMissionText", "Հանրահյնացնել արհեստական բանականության կրթությունը Հայաստանում, դարձնելով այն հասանելի, պրակտիկ և մոտիվացնող բոլորի համար։"},
        {"HomeWhyTitle", "Ինչու՞ մասնակցել"},
        {"HomeWhyText", "Ստացիր իրական ԱԲ հմտություններ, միացիր նորարարների հետ և անդամակցիր EIF–ի կենսունակ համայնքին։"},
        {"HomeNewsTitle", "Վերջին նորություններն ու միջոցառումները"},
        {"HomeNewsText", "Եղիր տեղեկացված մեր աշխատարանների, հեքաթոնների և AI4ALL նպատակների մասին։"},
        {"HomeCta", "Միացիր AI4ALL-ին այսօր։"},
        {"HomeEIFTitle", "EIF-ի մասին"},
        {"HomeEIFText", "Ձեռնարկությունների ինկուբատոր հիմնադրամը (EIF) Հայաստանի առաջատար տեխնոլոգիական ինկուբատորն է, որը խթանում է նորարարությունն ու բարձր տեխնոլոգիաներ։"},

        {"ResourcesTitle", "Ռեսուրսներ"},

        {"ChatbotTitle", "AI4ALL Օգնակից"},

        {"ContactTitle", "Կապ մեզ հետ"},
        {"ContactEmail", "Էլ. փոստ"},
        {"ContactPhone", "Հեռախոս"},
        {"ContactFormName", "Ձեր անունը"},
        {"ContactFormEmail", "Ձեր էլ. փոստը"},
        {"ContactFormMessage", "Ձեր հաղորդագրությունը"},
        {"ContactFormSend", "Ուղարկել"},
        {"ContactFormSuccess", "Շնորհակալություն! Ձեր հաղորդագրությունը ուղարկվել է։"},
        {"ChatBotWelcome", "Բարի գալուստ AI4ALL Օգնակից էջ՝ ձեր անձնական հարթակը արագ օգնության և մեր AI4ALL ծրագրի մասին տեղեկությունների համար։ Այս էջը ներկայում գտնվում է զարգացման փուլում, սակայն կարող եք հենց հիմա փորձարկել բետա-չաթբոտը՝ սեղմելով փոքրիկ զրուցակցի (chat) պատկերակին, որը գտնվում է էջի ներքևի աջ անկյունում։ Սեղմելիս կհանձնվի նրբացած զրույցի պատուհան, որտեղ կարող եք տպել ձեր հարցերը կամ ընտրել նախօրոք պատրաստված տեքստային հրահանգներ։ Անկախ նրանից, թե ուզում եք տեղեկանալ հաջորդ աշխատարանների ժամանակացույցին, ճշտել մեր ուսումնական մոդուլների մասին մանրամասները կամ ստանալ տեխնիկական խորհուրդներ Python և մեքենայական ուսուցման օգտագործման վերաբերյալ՝ AI4ALL Օգնակիցը կպատասխանի անմիջապես։\r\n\r\nՄեր չաթբոտը աշխատում է բաց կոդով conversational AI շարժիչի վրա, ինչը թույլ է տալիս հասկանալ և պատասխանել հարցումների լայն շրջանակի՝ սկսած տրամաբանության և ծրագրավորման մանրամասներից մինչև նեյրոնային ցանցերի և տվյալների նախապատրաստման տեսական հիմնավորում։ Քանի որ այս պահին դուք գործ ունեք բետա տարբերակի հետ, կարող եք հանդիպել տեղ-տեղ օրինակազուրկ պատասխանների կամ փոքր թերությունների. մենք դրանք կարգավորելու և բարելավելու վրա աշխատում ենք անընդմեջ։ Խրախուսում ենք հարցնել և՛ ընդհանուր (“Ինչ է համակարգչային տեսողականություն՞”), և՛ կոնկրետ (“Ինչպես նախապատրաստեմ պատկերները կոնվոլուցիոն նեյրոնային ցանցի համար?”) հարցեր, ինչպես նաև կիսվել ձեր կարծիքներով՝ օգտագործելով զրույցի միջերեսում գտվող ֆիդբեք (feedback) կոճակը։ Ձեր հետադարձ կապը կաջակցի մեր տեխնոլոգիայի հետագա կատարելագործմանը։\r\n\r\nԸնդհատակ կա, որ մեր թիմը աշխատում է ավելի հզոր գործառույթների վրա՝ ռեսուրսների տվյալների շտեմարանից գիտելիքների վերամշակում, համատեքստային շարունակական զրույցներ և բազմալեզու աջակցություն (հասկանալի լինելու համար՝ և՛ հայերեն, և՛ անգլերեն լեզուներով)։ Այս ընթացքում համարձակ հարցրեք, խնդրեք օրինակներ կամ կոդային հատվածներ՝ ուղղակի զրույցի պատուհանում։ Շնորհակալ ենք, որ օգտվում եք մեր նորարարական գործիքից. միասին կընթանանք դեպի ավելի խելացի, ճշգրիտ և ձեր ԱԲ ուսման ուղեցույցը դարձած օգնականի ստեղծմանը։" },
        {"ContactFollowTitle", "Հետևեք մեզ այստեղ" },

        // About page
    {"AboutTitle", "AI4ALL-ի մասին" },
    {"AboutHero", "Հայաստանի ԱԲ նորարարների ապագան՝ այսօր" },
    {"AboutDescription", "AI4ALL-ը Ձեռնարկությունների ինկուբատոր հիմնադրամի (EIF) առաջատար կրթական նախաձեռնությունն է, որ旨 է հանրայնացնել և հնարավորինս մատչելի դարձնել արհեստական բանականության ոլորտը Հայաստանում: Ծրագիրը համադրում է առցանց մոդուլներ, իրական կյանքում իրականացվող վարպետաց դասեր և թիմային հեքաթոններ՝ տրամադրելով մասնակիցներին թեորիայի խոր գիտելիք (գծային ալգեբրա, հավանականություն, օպտիմալացում) և Python լեզվով կիրառողական նախագծեր ստեղծելու հմտություններ:" },
    {"AboutStats", "Ծրագիրը սկսել է 750+ ուսանողով 30+ դպրոցի և համալսարանի ուսանողներից, անցկացրել է 20+ հեքաթոն՝ ավելի քան 1,800 մասնակիցով, և ներկայացրել է 300+ ժամ տեսադասախոսություններ առցանց հարթակում:" },
    {"AboutCommunity", "AI4ALL-ը զարգացնում է ինտենսիվ համայնքային միջավայր. Երևան, Գյումրի և Վանաձոր քաղաքներում տեղական ճյուղերը կազմակերպում են հանդիպումներ, դեմո օրեր և սեմինարներ; առցանց ֆորումն առաջարկում է կոդային օրինակներ, գրադարանների ուղեցույցներ և գործընկերային քննարկումներ; եռամսյակային հեքաթոնները նորարարական լուծումների մրցույթ են տալիս մասնակիցներին:" },
    {"AboutMentorship", "Մենթորական ծրագիրը յուրաքանչյուր ուսանողին զուգորդում է ԱԲ ոլորտի փորձագետի հետ՝ տրամադրելով անհատականացված խորհուրդներ տվյալների էթիկայի, նախագծի պլանավորման և մասնագիտական զարգացման վերաբերյալ:" },
    {"AboutFuture", "Վերացուցիչ նպատակների թվում են ամրապնդողական ուսուցման, ԱԲ էթիկայի թեմաների ընդգրկումը, համահայկական և միջազգային համալսարանների հետ համագործակցությունները և EIF–ի գործընկեր ընկերություններում մանր պրակտիկումների ստեղծումը:" },
    {"AboutGalleryTitle", "Պատկերասրահ և կարևոր պահեր" },
    {"AboutTimelineTitle", "Հիմնական փուլեր" },
    {"About2023", "Համայնքային ճյուղեր 3 քաղաքներում, 250+ ժամ տեսադասախոսություններ և միջազգային գործընկերություններ։"   },
    {"About2021", "500+ մասնակից, 10+ հեքաթոններ և նոր առցանց մոդուլներ։"   },
        {"About2019", "AI4ALL-ը մեկնարկում է առաջին աշխատարաններով և հեքաթոններով։"     } ,

        {"HomeNav", "Գլխավոր"},
        {"AboutNav", "Մեր մասին" },
        {"ContactNav", "Հետադարձ կապ" },
        {"ResourcesNav", "Ռեսուրսներ" },
        {"ChatbotNav", "Չատբոտ" }
    };

    public static string GetText(string key, PageLanguageType lang)
    {
        return lang == PageLanguageType.HY
            ? hy.GetValueOrDefault(key, en.GetValueOrDefault(key, key))
            : en.GetValueOrDefault(key, key);
    }
}
