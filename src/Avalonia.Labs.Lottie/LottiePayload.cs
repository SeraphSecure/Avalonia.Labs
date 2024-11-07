using System;
using Avalonia.Media;

namespace SeraphSecure.AvaloniaLottie;

internal record struct LottiePayload(
    LottieCommand LottieCommand,
    SkiaSharp.Skottie.Animation? Animation = null,
    Stretch? Stretch = null,
    StretchDirection? StretchDirection = null,
    int? RepeatCount = null,
    float? SeekFrame = null,
    float? SeekProgress = null,
    Action? OnAnimationCompleted = null,
    Action<int>? OnAnimationCompletedRepetition = null);
