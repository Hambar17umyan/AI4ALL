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

        // About page
{"AboutTitle", "About AI4ALL"},
{"AboutDescription", "Learn about the AI4ALL initiative, its objectives, and the role of EIF in driving AI education."},

{"AboutMissionTitle", "Our Mission"},
{"AboutMissionText", "AI4ALL’s mission is to democratize AI education in Armenia, equipping young innovators with hands-on experience and critical thinking skills."},

{"AboutVisionTitle", "Our Vision"},
{"AboutVisionText", "We envision an Armenia where AI fluency is as fundamental as literacy, and where every student can shape the future of technology."},

{"AboutEIFSupportTitle", "EIF’s Support"},
{"AboutEIFSupportText", "The Enterprise Incubator Foundation provides mentorship, infrastructure, and funding to help AI4ALL scale its training programs and labs."},

{"AboutImpactTitle", "Our Impact"},
{"AboutImpactText", "Since launch, AI4ALL has trained over 500 students, hosted 10+ hackathons, and partnered with universities and industry leaders across Armenia."},

{"AboutTimelineTitle", "Key Milestones"},
{"AboutTimeline2024Title", "2024: Launch & Pilots"},
{"AboutTimeline2024Text", "Pilot workshops rolled out in Yerevan and Gyumri, engaging 200+ participants."},
{"AboutTimeline2025Title", "2025: Expansion"},
{"AboutTimeline2025Text", "Program expanded to regional centers, introduced advanced AI labs, and launched online learning modules."},

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

        // About page translations (hy dictionary)
{ "AboutTitle",             "AI4ALL-ի մասին" },
{ "AboutDescription",       "Ծանոթացեք AI4ALL նախաձեռնությանը, դրա նպատակներին և EIF-ի դերին ԱԲ կրթության խթանման գործում։" },

{ "AboutMissionTitle",      "Մեր առաքելությունը" },
{ "AboutMissionText",       "AI4ALL–ի առաքելությունն է հանրայնացնել ԱԲ կրթությունը Հայաստանում՝ ապահովելով ուսանողների համար հմտությունների ձեռքբերումը և ստեղծարար մտածողության զարգացումը։" },

{ "AboutVisionTitle",       "Մեր տեսլականը" },
{ "AboutVisionText",        "Մենք պատկերացնում ենք Հայաստանը որպես երկիր, որտեղ ԱԲ ընտիր ուսուցումը համարվում է հիմնական գրագիտության բաղադրիչ, և յուրաքանչյուր ուսանող կարող է ձեւակերպել տեխնոլոգիական ապագան։" },

{ "AboutEIFSupportTitle",   "EIF–ի աջակցությունը" },
{ "AboutEIFSupportText",    "Ձեռնարկությունների ինկուբատոր հիմնադրամը տրամադրում է մենթորություն, ենթակառուցվածք և ֆինանսավորում՝ աջակցելու AI4ALL ծրագրերի և լաբորատորիաների ընդլայնմանը։" },

{ "AboutImpactTitle",       "Մեր ազդեցությունը" },
{ "AboutImpactText",        "Ծրագրի մեկնարկից ի վեր AI4ALL–ը վերապատրաստել է ավելի քան 500 ուսանող, կազմակերպել 10+ հեքաթոն և համագործակցել համալսարանների և արդյունաբերական գործընկերների հետ։" },

{ "AboutTimelineTitle",     "Հիմնական ստուգագծերը" },
{ "AboutTimeline2024Title", "2024թ․՝ մեկնարկ և փորձարկում" },
{ "AboutTimeline2024Text",  "Փորձարկիչ աշխատարաններ կազմակերպվեցին Երևանում և Գյումրիում՝ ընդգրկելով ավելի քան 200 մասնակից։" },
{ "AboutTimeline2025Title", "2025թ․՝ ընդլայնում" },
{ "AboutTimeline2025Text",  "Ծրագիրը ընդարձակվեց Հայաստանի մարզերում, ներկայացվեցին նոր առաջադեմ ԱԲ լաբորատորիաներ և սկսվեց առցանց ուսուցման մոդուլների իրականացումը։" },

    };

    public static string GetText(string key, PageLanguageType lang)
    {
        return lang == PageLanguageType.HY
            ? hy.GetValueOrDefault(key, en.GetValueOrDefault(key, key))
            : en.GetValueOrDefault(key, key);
    }
}
