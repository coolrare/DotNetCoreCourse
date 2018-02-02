## 使用物件瀏覽器查看查看使用組件與實作 APIs

### 開啟 .NET Framework 4.6.1 專案 (NETFramework)

* 使用物件瀏覽器查看 System.Collections 組件路徑
* 確認該組件實作了多少 APIs

### 開啟 .NET Core 2.0 專案 (CoreConsole)

* 使用物件瀏覽器查看 System.Collections 組件路徑
* 確認該組件實作了多少 APIs

### 開啟 .NET Standard 2.0 類別庫專案 (NETSandardLib)

* 使用物件瀏覽器查看 System.Collections 組件路徑
* 確認該組件實作了多少 APIs ( **完全無實作** )

### 開啟 PCL 類別庫專案 (PCLLib)

* 使用物件瀏覽器查看 System.Collections 組件路徑
* 確認該組件實作了多少 APIs

## 查看在不同平台架構下使用 DateTime 的組件相依性

### 請開啟 NETPackage.sln 方案

* 實驗 1：

  * 將 01NETFramework 設為啟始專案
  * 執行該專案，並記下執行結果

* 實驗 2：

  * 將 02NETCore20 設為啟始專案
  * 執行該專案，並記下執行結果
  * 比較與實驗 1 的差異之處

* 實驗 3：

  * 將 01NETFramework 設為啟始專案
  * 加入 03NETStandard20 專案參考
  * 執行該專案，並記下執行結果

* 實驗 4：

  * 將 02NETCore20 設為啟始專案
  * 加入 03NETStandard20 專案參考
  * 執行該專案，並記下執行結果
