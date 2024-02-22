using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UDS.Net.API.Entities
{
    /// <summary>
    /// Clinician Judgment of Symptoms
    /// </summary>
    [Table("tbl_B9s")]
    public class B9 : Form
    {
        [Comment("Does the participant report a decline in any cognitive domain (relative to stable baseline prior to onset of current syndrome)?")]
        public int? DECCOG { get; set; }
        [Comment("Does the participant report a decline in any motor domain (relative to stable baseline prior to onset of current syndrome)?")]
        public int? DECMOT { get; set; }
        [Comment("Does the participant report the development of any significant neuropsychiatric/behavioral symptoms (relative to stable baseline prior to onset of current syndrome)?")]
        public int? PSYCHSYM { get; set; }
        [Comment("Does the co-participant report a decline in any cognitive domain (relative to stable baseline prior to onset of current syndrome)?")]
        public int? DECCOGIN { get; set; }
        [Comment("Does the co-participant report a change in any motor domain (relative to stable baseline prior to onset of current syndrome)?")]
        public int? DECMOTIN { get; set; }
        [Comment("Does the co-participant report the development of any significant neuropsychiatric/behavioral symptoms (relative to stable baseline prior to onset of current syndrome)?")]
        public int? PSYCHSYMIN { get; set; }
        [Comment("Does the participant have any neuropsychiatric/behavioral symptoms or declines in any cognitive or motor domain?")]
        public bool? DECCLIN { get; set; }
        [Comment("Based on the clinician’s judgment, is the participant currently experiencing meaningful impairment in cognition?")]
        public bool? DECCLCOG { get; set; }
        [Comment("Indicate whether the participant currently is meaningfully impaired in memory.")]
        public int? COGMEM { get; set; }
        [Comment("Indicate whether the participant currently is meaningfully impaired in orientation.")]
        public int? COGORI { get; set; }
        [Comment("Indicate whether the participant currently is meaningfully impaired in executive function (judgment, planning, and problem-solving)")]
        public int? COGJUDG { get; set; }
        [Comment("Indicate whether the participant currently is meaningfully impaired in language")]
        public int? COGLANG { get; set; }
        [Comment("Indicate whether the participant currently is meaningfully impaired in visuospatial function")]
        public int? COGVIS { get; set; }
        [Comment("Indicate whether the participant currently is meaningfully impaired in attention/concentration")]
        public int? COGATTN { get; set; }
        [Comment("Indicate whether the participant currently has fluctuating cognition")]
        public int? COGFLUC { get; set; }
        [Comment("Other cognitive impairment")]
        public int? COGOTHR { get; set; }
        [Comment("Specify other cognitive domains")]
        [MaxLength(60)]
        public string? COGOTHRX { get; set; }
        [Comment("If any of the cognitive-related behavioral symptoms in 9a-9h are present, at what age did they begin?")]
        public int? COGAGE { get; set; }
        [Comment("Indicate the mode of onset for the most prominent cognitive problem that is causing the participant's complaints and/or affecting the participant's function.")]
        public int? COGMODE { get; set; }
        [Comment("Specify other mode of onset of cognitive symptoms")]
        [MaxLength(60)]
        public string? COGMODEX { get; set; }
        [Comment("Based on the clinician’s judgment, is the participant currently experiencing any kind of behavioral symptoms?")]
        public int? DECCLBE { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — Apathy, withdrawal")]
        public int? BEAPATHY { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — Depressed mood")]
        public int? BEDEP { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — Anxiety")]
        public int? BEANX { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior - Euphoria")]
        public int? BEEUPH { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — Irritability")]
        public int? BEIRRIT { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — Agitation")]
        public int? BEAGIT { get; set; }
        [Comment("If any of the mood-related behavioral symptoms in 12a-12f are present, at what age did they begin?")]
        public int? BEHAGE { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — Psychosis — Visual hallucinations")]
        public int? BEVHALL { get; set; }
        [Comment("IF YES, do their hallucinations include patterns that are not definite objects, such as pixelation of flat uniform surfaces?")]
        public int? BEVPATT { get; set; }
        [Comment("IF YES, do their hallucinations include well formed and detailed images of objects or people, either as independent images or as part of other objects?")]
        public int? BEVWELL { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — Psychosis — Auditory hallucinations")]
        public int? BEAHALL { get; set; }
        [Comment("IF YES, do the auditory hallucinations include simple sounds like knocks or other simple sounds?")]
        public int? BEAHSIMP { get; set; }
        [Comment("IF YES, do the auditory hallucinations include complex sounds like voices speaking words, or music?")]
        public int? BEAHCOMP { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — Psychosis — Abnormal, false, or delusional beliefs")]
        public int? BEDEL { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — Aggression")]
        public int? BEAGGRS { get; set; }
        [Comment("If any of the psychosis and impulse control-related behavioral symptoms in 12h-12k are present, at what age did they begin?")]
        public int? PSYCHAGE { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — Disinhibition")]
        public int? BEDISIN { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — Personality change")]
        public int? BEPERCH { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — Loss of empathy")]
        public int? BEEMPATH { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — Obsessions/compulsions")]
        public int? BEOBCOM { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — Explosive anger")]
        public int? BEANGER { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior - Substance use")]
        public int? BESUBAB { get; set; }
        [Comment("Alcohol use")]
        public bool? ALCUSE { get; set; }
        [Comment("Sedative/hypnotic use")]
        public bool? SEDUSE { get; set; }
        [Comment("Opiate use")]
        public bool? OPIATEUSE { get; set; }
        [Comment("Cocaine use")]
        public bool? COCAINEUSE { get; set; }
        [Comment("Other substance use")]
        public bool? OTHSUBUSE { get; set; }
        [Comment("Specify other substance use")]
        [MaxLength(60)]
        public string? OTHSUBUSEX { get; set; }
        [Comment("If any of the personality-related behavioral symptoms in 12m-12r are present, at what age did they begin?")]
        public int? PERCHAGE { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior — REM sleep behavior disorder")]
        public int? BEREM { get; set; }
        [Comment("IF YES, at what age did the dream enactment behavior begin?")]
        public int? BEREMAGO { get; set; }
        [Comment("Was REM sleep behavior disorder confirmed by polysomnography?")]
        public int? BEREMCONF { get; set; }
        [Comment("Other behavioral symptom")]
        public int? BEOTHR { get; set; }
        [Comment("Participant currently manifests meaningful change in behavior - Other, specify")]
        public string? BEOTHRX { get; set; }
        [Comment("Overall mode of onset for behavioral symptoms")]
        public int? BEMODE { get; set; }
        [Comment("Other mode of onset - specify")]
        public string? BEMODEX { get; set; }
        [Comment("Based on the clinician’s judgment, is the participant currently experiencing any motor symptoms?")]
        public bool? DECCLMOT { get; set; }
        [Comment("Indicate whether the participant currently has meaningful changes in motor function — Gait disorder")]
        public int? MOGAIT { get; set; }
        [Comment("Indicate whether the participant currently has meaningful changes in motor function — Falls")]
        public int? MOFALLS { get; set; }
        [Comment("Indicate whether the participant currently has meaningful changes in motor function — Slowness")]
        public int? MOSLOW { get; set; }
        [Comment("Indicate whether the participant currently has meaningful changes in motor function — Tremor")]
        public int? MOTREM { get; set; }
        [Comment("Indicate whether the participant currently has meaningful changes in motor function — Limb weakness")]
        public int? MOLIMB { get; set; }
        [Comment("Indicate whether the participant currently has meaningful changes in motor function — Change in facial expression")]
        public int? MOFACE { get; set; }
        [Comment("Indicate whether the participant currently has meaningful changes in motor function — Change in speech")]
        public int? MOSPEECH { get; set; }
        [Comment("If changes in motor function are present in 15a-15g, at what age did they begin?")]
        public int? MOTORAGE { get; set; }
        [Comment("Indicate the mode of onset for the most prominent motor problem that is causing the participant's complaints and/or affecting the participant's function.")]
        public int? MOMODE { get; set; }
        [Comment("Indicate mode of onset for the most prominent motor problem that is causing the participant's complains and or affecting the participant's function - Other, specify")]
        public string? MOMODEX { get; set; }
        [Comment("Were changes in motor function suggestive of parkinsonism?")]
        public int? MOMOPARK { get; set; }
        [Comment("Were changes in motor function suggestive of amyotrophic lateral sclerosis?")]
        public int? MOMOALS { get; set; }
        [Comment("Overall course of decline of cognitive / behavorial / motor syndrome")]
        public int? COURSE { get; set; }
        [Comment("Indicate the predominant domain that was first recognized as changed in the participant")]
        public int? FRSTCHG { get; set; }
    }
}

