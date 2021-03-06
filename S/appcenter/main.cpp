#include "stdafx.h"
#include "vld.h"
#include "CenterApp.h"
BOOL WINAPI onControl(DWORD CtrlType)
{
    if (CTRL_CLOSE_EVENT == CtrlType)
    {
        App::Instance->quit();
        while (App::Instance)
            Platform::sleep(5);
    }
    return TRUE;
}
#pragma comment(linker, "/subsystem:\"windows\" /entry:\"mainCRTStartup\"")
int main(int narg, char* argv[])
{
    int ret = 0;
    {
        freopen("game.loginapp.txt", "w", stdout);
        //freopen("COUT", "w", stdout);
        SetConsoleCtrlHandler(onControl, TRUE);
        CenterApp app(narg, argv);
        app.run();
    }

    return ret;
}

