#import <UIKit/UIKit.h>

extern "C" {
    // Play physical impact haptics (Light = 0, Medium = 1, Heavy = 2)
    void _PlayImpact(int style) {
        UIImpactFeedbackStyle impactStyle = (UIImpactFeedbackStyle)style;
        UIImpactFeedbackGenerator *generator = [[UIImpactFeedbackGenerator alloc] initWithStyle:impactStyle];
        [generator prepare];
        [generator impactOccurred];
    }

    // Play notification haptics (Success = 0, Warning = 1, Error = 2)
    void _PlayNotification(int type) {
        UINotificationFeedbackType notifType = (UINotificationFeedbackType)type;
        UINotificationFeedbackGenerator *generator = [[UINotificationFeedbackGenerator alloc] init];
        [generator prepare];
        [generator notificationOccurred:notifType];
    }
    
    // Play selection haptic feedback
    void _PlaySelection() {
        UISelectionFeedbackGenerator *generator = [[UISelectionFeedbackGenerator alloc] init];
        [generator prepare];
        [generator selectionChanged];
    }
}