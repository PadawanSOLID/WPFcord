using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace WPFcord.CustomAnimation
{
    public class CornerRadiusAnimation : AnimationTimeline
    {
        public CornerRadius From
        {
            get => (CornerRadius)GetValue(FromProperty);
            set => SetValue(FromProperty, value);
        }

        public static readonly DependencyProperty FromProperty = DependencyProperty.Register("From", typeof(CornerRadius), typeof(CornerRadiusAnimation));

        public CornerRadius To
        {
            get => (CornerRadius)GetValue(ToProperty);
            set => SetValue(ToProperty, value);
        }

        public static readonly DependencyProperty ToProperty = DependencyProperty.Register("To", typeof(CornerRadius), typeof(CornerRadiusAnimation));

        public override Type TargetPropertyType => typeof(CornerRadius);

        protected override Freezable CreateInstanceCore()
        {
            return new CornerRadiusAnimation();
        }

        public override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock)
        {
            if (animationClock.CurrentProgress == null)
            {
                return From;
            }
            double progress = animationClock.CurrentProgress.Value;

            return new CornerRadius(
                From.TopLeft + (To.TopLeft - From.TopLeft) * progress,
                From.TopRight + (To.TopRight - From.TopRight) * progress,
                From.BottomRight + (To.BottomRight - From.BottomRight) * progress,
                From.BottomLeft + (To.BottomLeft - From.BottomLeft) * progress
            );
        }
    }
}
