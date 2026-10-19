void GameModule_BattleGameSceneManager__RecordPlayerOpenHexTypeCount(
        GameModule_BattleGameSceneManager_o *this,
        int32_t quality,
        const MethodInfo *method)
{
  switch ( quality )
  {
    case 0:
      ++*(_DWORD *)&this->fields._unknown_object_0010_to_01FF[432];
      break;
    case 1:
      ++*(_DWORD *)&this->fields._unknown_object_0010_to_01FF[436];
      break;
    case 2:
      ++*(_DWORD *)&this->fields._unknown_object_0010_to_01FF[440];
      break;
    case 3:
      ++*(_DWORD *)&this->fields._unknown_object_0010_to_01FF[444];
      break;
    default:
      return;
  }
}
