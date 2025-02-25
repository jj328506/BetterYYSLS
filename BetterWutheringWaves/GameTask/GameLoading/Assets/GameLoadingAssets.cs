using YYSLS.Core.Recognition;
using YYSLS.GameTask.Model;
using OpenCvSharp;

namespace YYSLS.GameTask.GameLoading.Assets;

public class GameLoadingAssets : BaseAssets<GameLoadingAssets>
{
    public RecognitionObject EnterGameRo;
    public RecognitionObject WelkinMoonRo;
    public RecognitionObject LoginRo;

    private GameLoadingAssets()
    {
        // EnterGameRo = new RecognitionObject
        // {
        //     Name = "EnterGame",
        //     RecognitionType = RecognitionTypes.TemplateMatch,
        //     TemplateImageMat = GameTaskManager.LoadAssetImage("AutoWood", "exit_welcome.png"),
        //     RegionOfInterest = new Rect(0, CaptureRect.Height / 2, CaptureRect.Width, CaptureRect.Height - CaptureRect.Height / 2),
        //     DrawOnWindow = false
        // }.InitTemplate();
        //
         //WelkinMoonRo = new RecognitionObject
         //{
           ///  Name = "WelkinMoon",
            // RecognitionType = RecognitionTypes.TemplateMatch,
            // TemplateImageMat = GameTaskManager.LoadAssetImage("GameLoading", "jryx.png"),
            // RegionOfInterest = new Rect(0, CaptureRect.Height / 2, CaptureRect.Width, CaptureRect.Height / 2),
            // DrawOnWindow = false
        // }.InitTemplate();

        LoginRo = new RecognitionObject
        {
            Name = "LoginButton",
            RecognitionType = RecognitionTypes.TemplateMatch,
            TemplateImageMat = GameTaskManager.LoadAssetImage("GameLoading", "login_button.png"), // 根据实际路径修改
            RegionOfInterest = new Rect(0, 0, CaptureRect.Width, 100), // 根据按钮实际位置调整ROI
            DrawOnWindow = false
        }.InitTemplate();
    }
}
