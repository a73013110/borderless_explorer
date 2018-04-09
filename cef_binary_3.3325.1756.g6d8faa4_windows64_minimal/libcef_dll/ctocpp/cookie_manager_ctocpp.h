// Copyright (c) 2018 The Chromium Embedded Framework Authors. All rights
// reserved. Use of this source code is governed by a BSD-style license that
// can be found in the LICENSE file.
//
// ---------------------------------------------------------------------------
//
// This file was generated by the CEF translator tool. If making changes by
// hand only do so within the body of existing method and function
// implementations. See the translator.README.txt file in the tools directory
// for more information.
//
// $hash=d967c0e61518d168787f50b394ffa3e5485203bf$
//

#ifndef CEF_LIBCEF_DLL_CTOCPP_COOKIE_MANAGER_CTOCPP_H_
#define CEF_LIBCEF_DLL_CTOCPP_COOKIE_MANAGER_CTOCPP_H_
#pragma once

#if !defined(WRAPPING_CEF_SHARED)
#error This file can be included wrapper-side only
#endif

#include <vector>
#include "include/capi/cef_cookie_capi.h"
#include "include/cef_cookie.h"
#include "libcef_dll/ctocpp/ctocpp_ref_counted.h"

// Wrap a C structure with a C++ class.
// This class may be instantiated and accessed wrapper-side only.
class CefCookieManagerCToCpp
    : public CefCToCppRefCounted<CefCookieManagerCToCpp,
                                 CefCookieManager,
                                 cef_cookie_manager_t> {
 public:
  CefCookieManagerCToCpp();

  // CefCookieManager methods.
  void SetSupportedSchemes(const std::vector<CefString>& schemes,
                           CefRefPtr<CefCompletionCallback> callback) OVERRIDE;
  bool VisitAllCookies(CefRefPtr<CefCookieVisitor> visitor) OVERRIDE;
  bool VisitUrlCookies(const CefString& url,
                       bool includeHttpOnly,
                       CefRefPtr<CefCookieVisitor> visitor) OVERRIDE;
  bool SetCookie(const CefString& url,
                 const CefCookie& cookie,
                 CefRefPtr<CefSetCookieCallback> callback) OVERRIDE;
  bool DeleteCookies(const CefString& url,
                     const CefString& cookie_name,
                     CefRefPtr<CefDeleteCookiesCallback> callback) OVERRIDE;
  bool SetStoragePath(const CefString& path,
                      bool persist_session_cookies,
                      CefRefPtr<CefCompletionCallback> callback) OVERRIDE;
  bool FlushStore(CefRefPtr<CefCompletionCallback> callback) OVERRIDE;
};

#endif  // CEF_LIBCEF_DLL_CTOCPP_COOKIE_MANAGER_CTOCPP_H_
