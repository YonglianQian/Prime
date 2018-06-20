/*! 
2 { 
3   "name": "Cookies", 
4   "property": "cookies", 
5   "tags": ["storage"], 
6   "authors": ["tauren"] 
7 } 
8 !*/ 
9 /* DOC 
10 Detects whether cookie support is enabled. 
11 */ 
12 define(['Modernizr'], function(Modernizr) { 
13   // https://github.com/Modernizr/Modernizr/issues/191 
14 
 
15   Modernizr.addTest('cookies', function() { 
16     // navigator.cookieEnabled cannot detect custom or nuanced cookie blocking 
17     // configurations. For example, when blocking cookies via the Advanced 
18     // Privacy Settings in IE9, it always returns true. And there have been 
19     // issues in the past with site-specific exceptions. 
20     // Don't rely on it. 
21 
 
22     // try..catch because some in situations `document.cookie` is exposed but throws a 
23     // SecurityError if you try to access it; e.g. documents created from data URIs 
24     // or in sandboxed iframes (depending on flags/context) 
25     try { 
26       // Create cookie 
27       document.cookie = 'cookietest=1'; 
28       var ret = document.cookie.indexOf('cookietest=') != -1; 
29       // Delete cookie 
30       document.cookie = 'cookietest=1; expires=Thu, 01-Jan-1970 00:00:01 GMT'; 
31       return ret; 
32     } 
33     catch (e) { 
34       return false; 
35     } 
36   }); 
37 }); 
