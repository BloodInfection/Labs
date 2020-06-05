#include <stdafx.h>
#include <Windows.h>
#define IDM_OPENN 3
#define IDM_CLOSEE 4


HWND win2hwnd;

int CALLBACK wWinMain(HINSTANCE hInstance, HINSTANCE, PWSTR szCmdLine, int nCmdShow) {
	MSG msg{};
	HWND hwnd{};
	WNDCLASSEX wc{ sizeof(WNDCLASSEX) };
	HBRUSH silver = CreateSolidBrush(RGB(221, 160, 221));

	wc.cbClsExtra = 0;
	wc.cbWndExtra = 0;
	wc.hbrBackground = silver;
	wc.hCursor = LoadCursor(nullptr, IDC_ARROW);
	wc.hIcon = LoadIcon(nullptr, IDI_APPLICATION);
	wc.hInstance = hInstance;

	wc.lpfnWndProc = [](HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)->LRESULT
	{
		PAINTSTRUCT ps;
		HDC hdc;
		RECT rectPlace;
		GetClientRect(hWnd, &rectPlace);
		static LPCWSTR text = L"Waiting for win1";
		static WPARAM hWndtoSend;
		
		
		switch (uMsg) {
		case WM_USER + 1:
		{
			win2hwnd = (HWND)wParam;
			text = L"have first win HWND";
			InvalidateRect(hWnd, &rectPlace, true);
			/*SetWindowPos(hWnd, HWND_BOTTOM, 0, 0, 450, 100, SWP_NOMOVE);*/
		}
		return 0;
		case WM_USER + 2:
		{
			/*ShowWindow(hWnd, SW_MAXIMIZE);*/
		}
		case WM_PAINT:
		{

			hdc = BeginPaint(hWnd, &ps);
			SetBkMode(hdc, TRANSPARENT);
			HFONT hFont = CreateFont(30, 0, 0, 0, 0, 0, 0, 0,
				DEFAULT_CHARSET,
				0, 0, 0, 0,
				L"Baron Neue"
			);
			SelectObject(hdc, hFont);
			SetTextColor(hdc, RGB(0, 0, 0));
			DrawText(hdc, text, wcslen(text), &rectPlace, DT_SINGLELINE | DT_CENTER | DT_VCENTER);
			EndPaint(hWnd, &ps);
		}
		return 0;
		case WM_LBUTTONDOWN:
		{
			ShowWindow(hWnd, SW_MAXIMIZE);
			
			
		}
		return 0;
	
		case WM_RBUTTONDOWN:
		{
			

			/*HDESK DesktopHandle = CreateDesktop(L"desktop", NULL, NULL, 0, GENERIC_ALL, NULL);
			if (!DesktopHandle)
			{
				MessageBox(NULL, L"Unable to CreateDesktop", L"Error", MB_OK);
			}

			SwitchDesktop(DesktopHandle);*/
			SetWindowPos(hWnd, HWND_TOPMOST, 0, 0, 450 /*width*/, 450 /*height*/, SWP_NOMOVE);
		}
			
			
		
		return 0;
		case WM_CREATE:
		{
			HMENU hMenubar = CreateMenu();
			HMENU hMenu = CreateMenu();
			AppendMenu(hMenubar, MF_POPUP, (UINT_PTR)hMenu, L"Меню");
			AppendMenu(hMenu, MF_STRING, IDM_OPENN, L"Открыть");
			AppendMenu(hMenu, MF_STRING, IDM_CLOSEE, L"Закрыть");
			SetMenu(hWnd, hMenubar);
		}
		return 0;
		case WM_COMMAND:
		{
			if (LOWORD(wParam) == IDM_OPENN)
			{
				WinExec("D:\\Profile\\Desktop\\LAB2\\LAB2_1\\Debug\\LAB2OK1.exe", SW_SHOW);
			}
			else if (LOWORD(wParam) == IDM_CLOSEE) {

				HWND fistWindow = FindWindow(L"Class", L"Lab_1");
				SendMessage(fistWindow, WM_USER + 2, NULL, NULL);
			}
		}
		return 0;
		case WM_DESTROY:
		{
			PostQuitMessage(0);
		}
		return 0;
		}
		return DefWindowProc(hWnd, uMsg, wParam, lParam);
	};
	wc.lpszClassName = L"Lab2_2";
	wc.lpszMenuName = NULL;
	wc.style = CS_VREDRAW | CS_HREDRAW;

	if (!RegisterClassEx(&wc)) {
		return EXIT_FAILURE;
	}
	hwnd = CreateWindow(wc.lpszClassName, L"Lab2_2", WS_OVERLAPPEDWINDOW, 0, 0, 450, 450, NULL, NULL, wc.hInstance, NULL);
	if (hwnd == INVALID_HANDLE_VALUE)
	{
		return EXIT_FAILURE;
	}
	ShowWindow(hwnd, nCmdShow);
	UpdateWindow(hwnd);

	while (GetMessage(&msg, nullptr, 0, 0)) {
		DispatchMessage(&msg);
	}
	return static_cast<int>(msg.wParam);
}

