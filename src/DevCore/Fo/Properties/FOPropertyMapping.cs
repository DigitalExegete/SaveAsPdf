﻿//Apache2, 2017, WinterDev
//Apache2, 2009, griffm, FO.NET
using System.Collections;

namespace Fonet.Fo.Properties
{
    internal class FOPropertyMapping
    {
        private static Hashtable mapping = new Hashtable();

        static FOPropertyMapping()
        {
            mapping.Add("source-document", SourceDocumentMaker.Maker("source-document"));
            mapping.Add("role", RoleMaker.Maker("role"));
            mapping.Add("absolute-position", AbsolutePositionMaker.Maker("absolute-position"));
            mapping.Add("top", TopMaker.Maker("top"));
            mapping.Add("right", RightMaker.Maker("right"));
            mapping.Add("bottom", BottomMaker.Maker("bottom"));
            mapping.Add("left", LeftMaker.Maker("left"));
            mapping.Add("azimuth", AzimuthMaker.Maker("azimuth"));
            mapping.Add("cue-after", CueAfterMaker.Maker("cue-after"));
            mapping.Add("cue-before", CueBeforeMaker.Maker("cue-before"));
            mapping.Add("elevation", ElevationMaker.Maker("elevation"));
            mapping.Add("pause-after", PauseAfterMaker.Maker("pause-after"));
            mapping.Add("pause-before", PauseBeforeMaker.Maker("pause-before"));
            mapping.Add("pitch", PitchMaker.Maker("pitch"));
            mapping.Add("pitch-range", PitchRangeMaker.Maker("pitch-range"));
            mapping.Add("play-during", PlayDuringMaker.Maker("play-during"));
            mapping.Add("richness", RichnessMaker.Maker("richness"));
            mapping.Add("speak", SpeakMaker.Maker("speak"));
            mapping.Add("speak-header", SpeakHeaderMaker.Maker("speak-header"));
            mapping.Add("speak-numeral", SpeakNumeralMaker.Maker("speak-numeral"));
            mapping.Add("speak-punctuation", SpeakPunctuationMaker.Maker("speak-punctuation"));
            mapping.Add("speech-rate", SpeechRateMaker.Maker("speech-rate"));
            mapping.Add("stress", StressMaker.Maker("stress"));
            mapping.Add("voice-family", VoiceFamilyMaker.Maker("voice-family"));
            mapping.Add("volume", VolumeMaker.Maker("volume"));
            mapping.Add("background-attachment", BackgroundAttachmentMaker.Maker("background-attachment"));
            mapping.Add("background-color", BackgroundColorMaker.Maker("background-color"));
            mapping.Add("background-image", BackgroundImageMaker.Maker("background-image"));
            mapping.Add("background-repeat", BackgroundRepeatMaker.Maker("background-repeat"));
            mapping.Add("background-position-horizontal", BackgroundPositionHorizontalMaker.Maker("background-position-horizontal"));
            mapping.Add("background-position-vertical", BackgroundPositionVerticalMaker.Maker("background-position-vertical"));
            mapping.Add("border-before-color", BorderBeforeColorMaker.Maker("border-before-color"));
            mapping.Add("border-before-style", BorderBeforeStyleMaker.Maker("border-before-style"));
            mapping.Add("border-before-width", BorderBeforeWidthMaker.Maker("border-before-width"));
            mapping.Add("border-after-color", BorderAfterColorMaker.Maker("border-after-color"));
            mapping.Add("border-after-style", BorderAfterStyleMaker.Maker("border-after-style"));
            mapping.Add("border-after-width", BorderAfterWidthMaker.Maker("border-after-width"));
            mapping.Add("border-start-color", BorderStartColorMaker.Maker("border-start-color"));
            mapping.Add("border-start-style", BorderStartStyleMaker.Maker("border-start-style"));
            mapping.Add("border-start-width", BorderStartWidthMaker.Maker("border-start-width"));
            mapping.Add("border-end-color", BorderEndColorMaker.Maker("border-end-color"));
            mapping.Add("border-end-style", BorderEndStyleMaker.Maker("border-end-style"));
            mapping.Add("border-end-width", BorderEndWidthMaker.Maker("border-end-width"));
            mapping.Add("border-top-color", BorderTopColorMaker.Maker("border-top-color"));
            mapping.Add("border-top-style", BorderTopStyleMaker.Maker("border-top-style"));
            mapping.Add("border-top-width", BorderTopWidthMaker.Maker("border-top-width"));
            mapping.Add("border-bottom-color", BorderBottomColorMaker.Maker("border-bottom-color"));
            mapping.Add("border-bottom-style", BorderBottomStyleMaker.Maker("border-bottom-style"));
            mapping.Add("border-bottom-width", BorderBottomWidthMaker.Maker("border-bottom-width"));
            mapping.Add("border-left-color", BorderLeftColorMaker.Maker("border-left-color"));
            mapping.Add("border-left-style", BorderLeftStyleMaker.Maker("border-left-style"));
            mapping.Add("border-left-width", BorderLeftWidthMaker.Maker("border-left-width"));
            mapping.Add("border-right-color", BorderRightColorMaker.Maker("border-right-color"));
            mapping.Add("border-right-style", BorderRightStyleMaker.Maker("border-right-style"));
            mapping.Add("border-right-width", BorderRightWidthMaker.Maker("border-right-width"));
            mapping.Add("padding-before", PaddingBeforeMaker.Maker("padding-before"));
            mapping.Add("padding-after", PaddingAfterMaker.Maker("padding-after"));
            mapping.Add("padding-start", PaddingStartMaker.Maker("padding-start"));
            mapping.Add("padding-end", PaddingEndMaker.Maker("padding-end"));
            mapping.Add("padding-top", PaddingTopMaker.Maker("padding-top"));
            mapping.Add("padding-bottom", PaddingBottomMaker.Maker("padding-bottom"));
            mapping.Add("padding-left", PaddingLeftMaker.Maker("padding-left"));
            mapping.Add("padding-right", PaddingRightMaker.Maker("padding-right"));
            mapping.Add("font-family", FontFamilyMaker.Maker("font-family"));
            mapping.Add("font-selection-strategy", FontSelectionStrategyMaker.Maker("font-selection-strategy"));
            mapping.Add("font-size", FontSizeMaker.Maker("font-size"));
            mapping.Add("font-stretch", FontStretchMaker.Maker("font-stretch"));
            mapping.Add("font-size-adjust", FontSizeAdjustMaker.Maker("font-size-adjust"));
            mapping.Add("font-style", FontStyleMaker.Maker("font-style"));
            mapping.Add("font-variant", FontVariantMaker.Maker("font-variant"));
            mapping.Add("font-weight", FontWeightMaker.Maker("font-weight"));
            mapping.Add("country", CountryMaker.Maker("country"));
            mapping.Add("language", LanguageMaker.Maker("language"));
            mapping.Add("script", ScriptMaker.Maker("script"));
            mapping.Add("hyphenate", HyphenateMaker.Maker("hyphenate"));
            mapping.Add("hyphenation-character", HyphenationCharacterMaker.Maker("hyphenation-character"));
            mapping.Add("hyphenation-push-character-count", HyphenationPushCharacterCountMaker.Maker("hyphenation-push-character-count"));
            mapping.Add("hyphenation-remain-character-count", HyphenationRemainCharacterCountMaker.Maker("hyphenation-remain-character-count"));
            mapping.Add("margin-top", MarginTopMaker.Maker("margin-top"));
            mapping.Add("margin-bottom", MarginBottomMaker.Maker("margin-bottom"));
            mapping.Add("margin-left", MarginLeftMaker.Maker("margin-left"));
            mapping.Add("margin-right", MarginRightMaker.Maker("margin-right"));
            mapping.Add("space-before", GenericSpace.Maker("space-before"));
            mapping.Add("space-after", GenericSpace.Maker("space-after"));
            mapping.Add("start-indent", StartIndentMaker.Maker("start-indent"));
            mapping.Add("end-indent", EndIndentMaker.Maker("end-indent"));
            mapping.Add("space-end", GenericSpace.Maker("space-end"));
            mapping.Add("space-start", GenericSpace.Maker("space-start"));
            mapping.Add("relative-position", RelativePositionMaker.Maker("relative-position"));
            mapping.Add("alignment-adjust", AlignmentAdjustMaker.Maker("alignment-adjust"));
            mapping.Add("alignment-baseline", AlignmentBaselineMaker.Maker("alignment-baseline"));
            mapping.Add("baseline-shift", BaselineShiftMaker.Maker("baseline-shift"));
            mapping.Add("display-align", DisplayAlignMaker.Maker("display-align"));
            mapping.Add("dominant-baseline", DominantBaselineMaker.Maker("dominant-baseline"));
            mapping.Add("relative-align", RelativeAlignMaker.Maker("relative-align"));
            mapping.Add("block-progression-dimension", BlockProgressionDimensionMaker.Maker("block-progression-dimension"));
            mapping.Add("content-height", ContentHeightMaker.Maker("content-height"));
            mapping.Add("content-width", ContentWidthMaker.Maker("content-width"));
            mapping.Add("height", HeightMaker.Maker("height"));
            mapping.Add("inline-progression-dimension", InlineProgressionDimensionMaker.Maker("inline-progression-dimension"));
            mapping.Add("max-height", MaxHeightMaker.Maker("max-height"));
            mapping.Add("max-width", MaxWidthMaker.Maker("max-width"));
            mapping.Add("min-height", MinHeightMaker.Maker("min-height"));
            mapping.Add("min-width", MinWidthMaker.Maker("min-width"));
            mapping.Add("scaling", ScalingMaker.Maker("scaling"));
            mapping.Add("scaling-method", ScalingMethodMaker.Maker("scaling-method"));
            mapping.Add("width", WidthMaker.Maker("width"));
            mapping.Add("hyphenation-keep", HyphenationKeepMaker.Maker("hyphenation-keep"));
            mapping.Add("hyphenation-ladder-count", HyphenationLadderCountMaker.Maker("hyphenation-ladder-count"));
            mapping.Add("last-line-end-indent", LastLineEndIndentMaker.Maker("last-line-end-indent"));
            mapping.Add("line-height", LineHeightMaker.Maker("line-height"));
            mapping.Add("line-height-shift-adjustment", LineHeightShiftAdjustmentMaker.Maker("line-height-shift-adjustment"));
            mapping.Add("line-stacking-strategy", LineStackingStrategyMaker.Maker("line-stacking-strategy"));
            mapping.Add("linefeed-treatment", LinefeedTreatmentMaker.Maker("linefeed-treatment"));
            mapping.Add("white-space-treatment", WhiteSpaceTreatmentMaker.Maker("white-space-treatment"));
            mapping.Add("text-align", TextAlignMaker.Maker("text-align"));
            mapping.Add("text-align-last", TextAlignLastMaker.Maker("text-align-last"));
            mapping.Add("text-indent", TextIndentMaker.Maker("text-indent"));
            mapping.Add("white-space-collapse", WhiteSpaceCollapseMaker.Maker("white-space-collapse"));
            mapping.Add("wrap-option", WrapOptionMaker.Maker("wrap-option"));
            mapping.Add("character", CharacterMaker.Maker("character"));
            mapping.Add("letter-spacing", LetterSpacingMaker.Maker("letter-spacing"));
            mapping.Add("suppress-at-line-break", SuppressAtLineBreakMaker.Maker("suppress-at-line-break"));
            mapping.Add("text-decoration", TextDecorationMaker.Maker("text-decoration"));
            mapping.Add("text-shadow", TextShadowMaker.Maker("text-shadow"));
            mapping.Add("text-transform", TextTransformMaker.Maker("text-transform"));
            mapping.Add("treat-as-word-space", TreatAsWordSpaceMaker.Maker("treat-as-word-space"));
            mapping.Add("word-spacing", WordSpacingMaker.Maker("word-spacing"));
            mapping.Add("color", ColorMaker.Maker("color"));
            mapping.Add("color-profile-name", ColorProfileNameMaker.Maker("color-profile-name"));
            mapping.Add("rendering-intent", RenderingIntentMaker.Maker("rendering-intent"));
            mapping.Add("clear", ClearMaker.Maker("clear"));
            mapping.Add("float", FloatMaker.Maker("float"));
            mapping.Add("break-after", GenericBreak.Maker("break-after"));
            mapping.Add("break-before", GenericBreak.Maker("break-before"));
            mapping.Add("keep-together", KeepTogetherMaker.Maker("keep-together"));
            mapping.Add("keep-with-next", KeepWithNextMaker.Maker("keep-with-next"));
            mapping.Add("keep-with-previous", KeepWithPreviousMaker.Maker("keep-with-previous"));
            mapping.Add("orphans", OrphansMaker.Maker("orphans"));
            mapping.Add("widows", WidowsMaker.Maker("widows"));
            mapping.Add("clip", ClipMaker.Maker("clip"));
            mapping.Add("overflow", OverflowMaker.Maker("overflow"));
            mapping.Add("reference-orientation", ReferenceOrientationMaker.Maker("reference-orientation"));
            mapping.Add("span", SpanMaker.Maker("span"));
            mapping.Add("leader-alignment", LeaderAlignmentMaker.Maker("leader-alignment"));
            mapping.Add("leader-pattern", LeaderPatternMaker.Maker("leader-pattern"));
            mapping.Add("leader-pattern-width", LeaderPatternWidthMaker.Maker("leader-pattern-width"));
            mapping.Add("leader-length", LeaderLengthMaker.Maker("leader-length"));
            mapping.Add("rule-style", RuleStyleMaker.Maker("rule-style"));
            mapping.Add("rule-thickness", RuleThicknessMaker.Maker("rule-thickness"));
            mapping.Add("active-state", ActiveStateMaker.Maker("active-state"));
            mapping.Add("auto-restore", AutoRestoreMaker.Maker("auto-restore"));
            mapping.Add("case-name", CaseNameMaker.Maker("case-name"));
            mapping.Add("case-title", CaseTitleMaker.Maker("case-title"));
            mapping.Add("destination-placement-offset", DestinationPlacementOffsetMaker.Maker("destination-placement-offset"));
            mapping.Add("external-destination", ExternalDestinationMaker.Maker("external-destination"));
            mapping.Add("indicate-destination", IndicateDestinationMaker.Maker("indicate-destination"));
            mapping.Add("internal-destination", InternalDestinationMaker.Maker("internal-destination"));
            mapping.Add("show-destination", ShowDestinationMaker.Maker("show-destination"));
            mapping.Add("starting-state", StartingStateMaker.Maker("starting-state"));
            mapping.Add("switch-to", SwitchToMaker.Maker("switch-to"));
            mapping.Add("target-presentation-context", TargetPresentationContextMaker.Maker("target-presentation-context"));
            mapping.Add("target-processing-context", TargetProcessingContextMaker.Maker("target-processing-context"));
            mapping.Add("target-stylesheet", TargetStylesheetMaker.Maker("target-stylesheet"));
            mapping.Add("marker-class-name", MarkerClassNameMaker.Maker("marker-class-name"));
            mapping.Add("retrieve-class-name", RetrieveClassNameMaker.Maker("retrieve-class-name"));
            mapping.Add("retrieve-position", RetrievePositionMaker.Maker("retrieve-position"));
            mapping.Add("retrieve-boundary", RetrieveBoundaryMaker.Maker("retrieve-boundary"));
            mapping.Add("format", FormatMaker.Maker("format"));
            mapping.Add("grouping-separator", GroupingSeparatorMaker.Maker("grouping-separator"));
            mapping.Add("grouping-size", GroupingSizeMaker.Maker("grouping-size"));
            mapping.Add("letter-value", LetterValueMaker.Maker("letter-value"));
            mapping.Add("blank-or-not-blank", BlankOrNotBlankMaker.Maker("blank-or-not-blank"));
            mapping.Add("column-count", ColumnCountMaker.Maker("column-count"));
            mapping.Add("column-gap", ColumnGapMaker.Maker("column-gap"));
            mapping.Add("extent", ExtentMaker.Maker("extent"));
            mapping.Add("flow-name", FlowNameMaker.Maker("flow-name"));
            mapping.Add("force-page-count", ForcePageCountMaker.Maker("force-page-count"));
            mapping.Add("initial-page-number", InitialPageNumberMaker.Maker("initial-page-number"));
            mapping.Add("master-name", MasterNameMaker.Maker("master-name"));
            mapping.Add("master-reference", MasterReferenceMaker.Maker("master-reference"));
            mapping.Add("maximum-repeats", MaximumRepeatsMaker.Maker("maximum-repeats"));
            mapping.Add("media-usage", MediaUsageMaker.Maker("media-usage"));
            mapping.Add("odd-or-even", OddOrEvenMaker.Maker("odd-or-even"));
            mapping.Add("page-height", PageHeightMaker.Maker("page-height"));
            mapping.Add("page-position", PagePositionMaker.Maker("page-position"));
            mapping.Add("page-width", PageWidthMaker.Maker("page-width"));
            mapping.Add("precedence", PrecedenceMaker.Maker("precedence"));
            mapping.Add("region-name", RegionNameMaker.Maker("region-name"));
            mapping.Add("border-after-precedence", BorderAfterPrecedenceMaker.Maker("border-after-precedence"));
            mapping.Add("border-before-precedence", BorderBeforePrecedenceMaker.Maker("border-before-precedence"));
            mapping.Add("border-collapse", BorderCollapseMaker.Maker("border-collapse"));
            mapping.Add("border-end-precedence", BorderEndPrecedenceMaker.Maker("border-end-precedence"));
            mapping.Add("border-separation", BorderSeparationMaker.Maker("border-separation"));
            mapping.Add("border-start-precedence", BorderStartPrecedenceMaker.Maker("border-start-precedence"));
            mapping.Add("caption-side", CaptionSideMaker.Maker("caption-side"));
            mapping.Add("column-number", ColumnNumberMaker.Maker("column-number"));
            mapping.Add("column-width", ColumnWidthMaker.Maker("column-width"));
            mapping.Add("empty-cells", EmptyCellsMaker.Maker("empty-cells"));
            mapping.Add("ends-row", EndsRowMaker.Maker("ends-row"));
            mapping.Add("number-columns-repeated", NumberColumnsRepeatedMaker.Maker("number-columns-repeated"));
            mapping.Add("number-columns-spanned", NumberColumnsSpannedMaker.Maker("number-columns-spanned"));
            mapping.Add("number-rows-spanned", NumberRowsSpannedMaker.Maker("number-rows-spanned"));
            mapping.Add("starts-row", StartsRowMaker.Maker("starts-row"));
            mapping.Add("table-layout", TableLayoutMaker.Maker("table-layout"));
            mapping.Add("table-omit-footer-at-break", TableOmitFooterAtBreakMaker.Maker("table-omit-footer-at-break"));
            mapping.Add("table-omit-header-at-break", TableOmitHeaderAtBreakMaker.Maker("table-omit-header-at-break"));
            mapping.Add("direction", DirectionMaker.Maker("direction"));
            mapping.Add("glyph-orientation-horizontal", GlyphOrientationHorizontalMaker.Maker("glyph-orientation-horizontal"));
            mapping.Add("glyph-orientation-vertical", GlyphOrientationVerticalMaker.Maker("glyph-orientation-vertical"));
            mapping.Add("text-altitude", TextAltitudeMaker.Maker("text-altitude"));
            mapping.Add("text-depth", TextDepthMaker.Maker("text-depth"));
            mapping.Add("unicode-bidi", UnicodeBidiMaker.Maker("unicode-bidi"));
            mapping.Add("writing-mode", WritingModeMaker.Maker("writing-mode"));
            mapping.Add("content-type", ContentTypeMaker.Maker("content-type"));
            mapping.Add("id", IdMaker.Maker("id"));
            mapping.Add("provisional-label-separation", ProvisionalLabelSeparationMaker.Maker("provisional-label-separation"));
            mapping.Add("provisional-distance-between-starts", ProvisionalDistanceBetweenStartsMaker.Maker("provisional-distance-between-starts"));
            mapping.Add("ref-id", RefIdMaker.Maker("ref-id"));
            mapping.Add("score-spaces", ScoreSpacesMaker.Maker("score-spaces"));
            mapping.Add("src", SrcMaker.Maker("src"));
            mapping.Add("visibility", VisibilityMaker.Maker("visibility"));
            mapping.Add("z-index", ZIndexMaker.Maker("z-index"));
            mapping.Add("background", BackgroundMaker.Maker("background"));
            mapping.Add("background-position", BackgroundPositionMaker.Maker("background-position"));
            mapping.Add("border", BorderMaker.Maker("border"));
            mapping.Add("border-bottom", BorderBottomMaker.Maker("border-bottom"));
            mapping.Add("border-color", BorderColorMaker.Maker("border-color"));
            mapping.Add("border-left", BorderLeftMaker.Maker("border-left"));
            mapping.Add("border-right", BorderRightMaker.Maker("border-right"));
            mapping.Add("border-style", BorderStyleMaker.Maker("border-style"));
            mapping.Add("border-spacing", BorderSpacingMaker.Maker("border-spacing"));
            mapping.Add("border-top", BorderTopMaker.Maker("border-top"));
            mapping.Add("border-width", BorderWidthMaker.Maker("border-width"));
            mapping.Add("cue", CueMaker.Maker("cue"));
            mapping.Add("font", FontMaker.Maker("font"));
            mapping.Add("margin", MarginMaker.Maker("margin"));
            mapping.Add("padding", PaddingMaker.Maker("padding"));
            mapping.Add("page-break-after", PageBreakAfterMaker.Maker("page-break-after"));
            mapping.Add("page-break-before", PageBreakBeforeMaker.Maker("page-break-before"));
            mapping.Add("page-break-inside", PageBreakInsideMaker.Maker("page-break-inside"));
            mapping.Add("pause", PauseMaker.Maker("pause"));
            mapping.Add("position", PositionMaker.Maker("position"));
            mapping.Add("size", SizeMaker.Maker("size"));
            mapping.Add("vertical-align", VerticalAlignMaker.Maker("vertical-align"));
            mapping.Add("white-space", WhiteSpaceMaker.Maker("white-space"));
            mapping.Add("xml:lang", XMLLangMaker.Maker("xml:lang"));
        }

        public static Hashtable getGenericMappings()
        {
            return mapping;
        }
    }
}