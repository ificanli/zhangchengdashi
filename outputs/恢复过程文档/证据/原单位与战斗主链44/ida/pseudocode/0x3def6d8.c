void GameModule_BattleGameSceneManager__RecordCameraAniNum(
        GameModule_BattleGameSceneManager_o *this,
        int32_t rotate,
        int32_t size,
        const MethodInfo *method)
{
  *(_DWORD *)&this->fields._unknown_object_0010_to_01FF[404] = rotate;
  *(_DWORD *)&this->fields._unknown_object_0010_to_01FF[408] = size;
}
