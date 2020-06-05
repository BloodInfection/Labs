#include "stdafx.h"
#include <Windows.h>
#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <map>
#include <tchar.h>
#include <process.h>
#include <stdlib.h>
#include <stdio.h>
#include <time.h>
#include <conio.h>
#include <sstream>
#include <malloc.h>
#include <memory.h>

#define MAX_LOADSTRING 100


HINSTANCE hInst;
LRESULT CALLBACK WndProc(HWND hWnd, UINT, WPARAM, LPARAM);
POINT c;
static int      cxClient, cyClient;
static POINT    ptCenter;
TCHAR WinName[] = _T("LAB4");

int WINAPI _tWinMain(HINSTANCE This,
	HINSTANCE Prev,
	LPTSTR cmd,
	int mode)
{
	HWND hWnd;
	MSG msg;
	WNDCLASS wc;
	wc.hInstance = This;
	wc.lpszClassName = WinName;
	wc.lpfnWndProc = WndProc;
	wc.style = CS_HREDRAW | CS_VREDRAW;
	wc.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wc.hCursor = LoadCursor(NULL, IDC_ARROW);
	wc.lpszMenuName = NULL;
	wc.cbClsExtra = 0;
	wc.cbWndExtra = 0;
	wc.hbrBackground = CreateSolidBrush(RGB(225, 225, 225));


	if (!RegisterClass(&wc)) return 0;
	hInst = This;
	hWnd = CreateWindow(WinName,
		_T("LAB4"),
		WS_OVERLAPPEDWINDOW,
		CW_USEDEFAULT,
		CW_USEDEFAULT,
		550,
		600,
		HWND_DESKTOP,
		NULL,
		This,
		NULL);
	HMENU hmenu1;
	hmenu1 = CreateMenu();
	HMENU hPopupMenu = CreatePopupMenu();
	AppendMenu(hmenu1, MF_STRING | MF_POPUP, (UINT)hPopupMenu, L"Заполнить");
	{
		AppendMenu(hPopupMenu, MF_STRING, 1000, L"Координаты");
		AppendMenu(hPopupMenu, MF_STRING, 1001, L"Полукруг");
	}
	HMENU hPopupMenu1 = CreatePopupMenu();
	AppendMenu(hmenu1, MF_STRING | MF_POPUP, (UINT)hPopupMenu1, L"Остановить");
	{
		AppendMenu(hPopupMenu1, MF_STRING, 1002, L"Координаты");
		AppendMenu(hPopupMenu1, MF_STRING, 1003, L"Полукруг");
	}
	AppendMenu(hmenu1, MF_STRING, 0, L"Закрыть");
	SetMenu(hWnd, hmenu1);
	ShowWindow(hWnd, mode);
	UpdateWindow(hWnd);


	while (GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	return 0;
}

HANDLE hGroupList;
HANDLE hSwing;
DWORD WINAPI Coordinate(LPVOID t);
DWORD WINAPI Pies(LPVOID t);

BOOL Prov1 = false;
BOOL Prov2 = false;


DWORD WINAPI  Coordinate(LPVOID t)
{

	while (Prov1)
	{
		RECT rect;
		PAINTSTRUCT ps;
		GetClientRect(HWND(t), &rect);
		HDC hdc = GetDC(HWND(t));
		SelectObject(hdc, GetStockObject(DC_PEN));
		SetDCPenColor(hdc, RGB(225, 225, 225));
		SelectObject(hdc, CreateSolidBrush(RGB(225, 225, 225)));
		Rectangle(hdc, 0, 0, 1000, 70);
		
		SetTextColor(hdc, RGB(rand() % 155, rand() % 155, rand() % 155));
		SetBkMode(hdc, TRANSPARENT);
		GetCursorPos(&c);
		//if ((c.x < 600+200) & (c.y < 305+220)) 
			//TextOut(hdc, c.x - 200, c.y - 230, new_buf + k, names[i]);
		std::basic_stringstream<TCHAR> ss;
		ss << c.x;
		std::basic_string<TCHAR> s;
		ss >> s;
		TextOut(hdc, 220, 50, s.c_str(), s.size());
		std::basic_stringstream<TCHAR> st;
		st << c.y;
		std::basic_string<TCHAR> k;
		st >> k;
		TextOut(hdc, 245, 50, TEXT(":"), k.size());
		TextOut(hdc, 250, 50, k.c_str(), k.size());
		DeleteObject(hdc);
		EndPaint(HWND(t), &ps);
		Sleep(100);
	}
	return 0;
}


DWORD WINAPI Pies(LPVOID t)
{
	bool left_side = true;

	while (Prov2) {

		RECT rect;
		//PAINTSTRUCT ps;
		GetWindowRect(HWND(t), &rect);
		HDC hdc = GetDC(HWND(t));
		HBRUSH hBrush;
		hBrush = CreateHatchBrush(HS_FDIAGONAL, RGB(38, 201, 255));

		if (left_side) {
			SelectObject(hdc, CreateSolidBrush(RGB(0, 0, 0)));
			Ellipse(hdc, ptCenter.x - 200, 100, ptCenter.x + 200, 500);
			SelectObject(hdc, GetStockObject(DC_PEN));
			SetDCPenColor(hdc, RGB(225, 225, 225));
			SelectObject(hdc, CreateSolidBrush(RGB(225, 225, 225)));
			Rectangle(hdc, 0, 70, ptCenter.x, 1000);
			Sleep(700);
			ReleaseDC(HWND(t), hdc);

			SelectObject(hdc, (HGDIOBJ)hBrush);
			DeleteObject(hBrush);
			left_side = false;
		}
		else
		{
			SelectObject(hdc, CreateSolidBrush(RGB(0, 0, 0)));
			Ellipse(hdc, ptCenter.x - 200, 100, ptCenter.x + 200, 500);
			SelectObject(hdc, GetStockObject(DC_PEN));
			SetDCPenColor(hdc, RGB(225, 225, 225));
			SelectObject(hdc, CreateSolidBrush(RGB(225, 225, 225)));
			Rectangle(hdc, ptCenter.x, 70, 1000, 1000);
			Sleep(700);
			ReleaseDC(HWND(t), hdc);
			SelectObject(hdc, (HGDIOBJ)hBrush);
			DeleteObject(hBrush);
			left_side = true;
		}
	}
	return 0;
}





LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	switch (message)
	{
	case WM_SIZE:
		cxClient = LOWORD(lParam);
		cyClient = HIWORD(lParam);

		ptCenter.x = cxClient / 2;
		ptCenter.y = cyClient / 2;
		break;
	case WM_COMMAND:
	{
		int wmId = LOWORD(wParam);
		switch (wmId)
		{
		case 1000:
		{
			Prov1 = true;
			hGroupList = CreateThread(NULL, 0, Coordinate, hWnd, 0, NULL);
			break;
		}
		case 1001:
		{
			Prov2 = true;
			hSwing = CreateThread(NULL, 0, Pies, hWnd, 0, NULL);
			break;
		}
		case 1002:
		{
			TerminateThread(hGroupList, 0);
			Prov1 = false;
			break;
		}
		case 1003:
		{

			TerminateThread(hSwing, 0);
			Prov2 = false;
			break;

		}
		case 0:
		{
			DestroyWindow(hWnd);
			break;
		}
		default:
			return DefWindowProc(hWnd, message, wParam, lParam);
		}

	}
	break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	default:
		return DefWindowProc(hWnd, message, wParam, lParam);
	}

	return 0;
}