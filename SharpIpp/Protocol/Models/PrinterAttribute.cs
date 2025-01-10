﻿using System.Collections.Generic;

namespace SharpIpp.Protocol.Models
{
    public static class PrinterAttribute
    {
        public const string CharsetSupported = "charset-supported";
        public const string PrinterUriSupported = "printer-uri-supported";
        public const string UriSecuritySupported = "uri-security-supported";
        public const string UriAuthenticationSupported = "uri-authentication-supported";
        public const string PrinterName = "printer-name";
        public const string PrinterLocation = "printer-location";
        public const string PrinterInfo = "printer-info";
        public const string PrinterMoreInfo = "printer-more-info";
        public const string PrinterDriverInstaller = "printer-driver-installer";
        public const string PrinterMakeAndModel = "printer-make-and-model";
        public const string PrinterMoreInfoManufacturer = "printer-more-info-manufacturer";
        public const string PrinterState = "printer-state";
        public const string PrinterStateReasons = "printer-state-reasons";
        public const string PrinterStateMessage = "printer-state-message";
        public const string IppVersionsSupported = "ipp-versions-supported";
        public const string OperationsSupported = "operations-supported";
        public const string MultipleDocumentJobsSupported = "multiple-document-jobs-supported";
        public const string CharsetConfigured = "charset-configured";
        public const string NaturalLanguageConfigured = "natural-language-configured";
        public const string GeneratedNaturalLanguageSupported = "generated-natural-language-supported";
        public const string DocumentFormatDefault = "document-format-default";
        public const string DocumentFormatSupported = "document-format-supported";
        public const string PrinterIsAcceptingJobs = "printer-is-accepting-jobs";
        public const string QueuedJobCount = "queued-job-count";
        public const string PrinterMessageFromOperator = "printer-message-from-operator";
        public const string ColorSupported = "color-supported";
        public const string ReferenceUriSchemesSupported = "reference-uri-schemes-supported";
        public const string PdlOverrideSupported = "pdl-override-supported";
        public const string PrinterUpTime = "printer-up-time";
        public const string PrinterCurrentTime = "printer-current-time";
        public const string MultipleOperationTimeOut = "multiple-operation-time-out";
        public const string CompressionSupported = "compression-supported";
        public const string JobKOctetsSupported = "job-k-octets-supported";
        public const string JobImpressionsSupported = "job-impressions-supported";
        public const string JobMediaSheetsSupported = "job-media-sheets-supported";
        public const string PagesPerMinute = "pages-per-minute";
        public const string PagesPerMinuteColor = "pages-per-minute-color";
        public const string PrintScalingSupported = "print-scaling-supported";
        public const string PrintScalingDefault = "print-scaling-default";
        public const string MediaDefault = "media-default";
        public const string MediaSupported = "media-supported";
        public const string SidesDefault = "sides-default";
        public const string SidesSupported = "sides-supported";
        public const string FinishingsDefault = "finishings-default";
        public const string FinishingsSupported = "finishings-supported";
        public const string PrinterResolutionDefault = "printer-resolution-default";
        public const string PrinterResolutionSupported = "printer-resolution-supported";
        public const string PrintQualityDefault = "print-quality-default";
        public const string PrintQualitySupported = "print-quality-supported";
        public const string JobPriorityDefault = "job-priority-default";
        public const string JobPrioritySupported = "job-priority-supported";
        public const string CopiesDefault = "copies-default";
        public const string CopiesSupported = "copies-supported";
        public const string OrientationRequestedDefault = "orientation-requested-default";
        public const string OrientationRequestedSupported = "orientation-requested-supported";
        public const string PageRangesSupported = "page-ranges-supported";
        public const string JobHoldUntilDefault = "job-hold-until-default";
        public const string JobHoldUntilSupported = "job-hold-until-supported";
        public const string OutputBinDefault = "output-bin-default";
        public const string OutputBinSupported = "output-bin-supported";
        public const string MediaColDefault = "media-col-default";
        public const string PrintColorModeDefault = "print-color-mode-default";
        public const string PrintColorModeSupported = "print-color-mode-supported";

        public static IEnumerable<string> GetAttributes(IppVersion version)
        {
            yield return CharsetSupported;
            yield return PrinterUriSupported;
            yield return UriSecuritySupported;
            yield return UriAuthenticationSupported;
            yield return PrinterName;
            yield return PrinterLocation;
            yield return PrinterInfo;
            yield return PrinterMoreInfo;
            yield return PrinterDriverInstaller;
            yield return PrinterMakeAndModel;
            yield return PrinterMoreInfoManufacturer;
            yield return PrinterState;
            yield return PrinterStateReasons;
            yield return PrinterStateMessage;
            yield return IppVersionsSupported ;
            yield return OperationsSupported;
            yield return MultipleDocumentJobsSupported;
            yield return CharsetConfigured;
            yield return NaturalLanguageConfigured;
            yield return GeneratedNaturalLanguageSupported;
            yield return DocumentFormatDefault;
            yield return DocumentFormatSupported;
            yield return PrinterIsAcceptingJobs;
            yield return QueuedJobCount;
            yield return PrinterMessageFromOperator;
            yield return ColorSupported;
            yield return ReferenceUriSchemesSupported;
            yield return PdlOverrideSupported;
            yield return PrinterUpTime;
            yield return PrinterCurrentTime;
            yield return MultipleOperationTimeOut;
            yield return CompressionSupported;
            yield return JobKOctetsSupported;
            yield return JobImpressionsSupported;
            yield return JobMediaSheetsSupported;
            yield return PagesPerMinute;
            yield return PagesPerMinuteColor;
            yield return PrintScalingSupported;
            yield return PrintScalingDefault;
            yield return MediaDefault;
            yield return MediaSupported;
            yield return SidesDefault;
            yield return SidesSupported;
            yield return FinishingsDefault;
            yield return FinishingsSupported;
            yield return PrinterResolutionDefault;
            yield return PrinterResolutionSupported;
            yield return PrintQualityDefault;
            yield return PrintQualitySupported;
            yield return JobPriorityDefault;
            yield return JobPrioritySupported;
            yield return CopiesDefault;
            yield return CopiesSupported;
            yield return OrientationRequestedDefault;
            yield return OrientationRequestedSupported;
            yield return PageRangesSupported;
            yield return JobHoldUntilDefault;
            yield return JobHoldUntilSupported;
            yield return OutputBinDefault;
            yield return OutputBinSupported;
            yield return MediaColDefault;
            yield return PrintColorModeDefault;
            yield return PrintColorModeSupported;
        }
    }
}
