**Plugins for Xamarin** で使われている **Bait and Switch** というテクニックの概要をデスクトップのコンソールアプリケーションで試してみるサンプルです。  
  
## App  
**Dll**、**DllA**、**DllB** のいずれも直接参照しないアプリ(**Library** のみ参照)
## AppA
  **Library** と **DllA** を参照したアプリ
## AppB
  **Library** と **DllB** を参照したアプリ
## Dll
  空実装 **DLL** 役の **DLL**
## DllA
  プラットフォーム用 **DLL** 役の **DLL** その1
## DllB
  プラットフォーム用 **DLL** 役の **DLL** その2
## Library
  **PCL** 共通プロジェクト役の **DLL**
