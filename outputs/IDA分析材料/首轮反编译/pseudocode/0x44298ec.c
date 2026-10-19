void GameModule_HexBehaviour__DetermineHexCamp(GameModule_HexBehaviour_o *self, const MethodInfo *method)
{
  GameModule_HexBehaviour_o *v2; // x19
  System_Collections_Generic_List_RoleBehaviour__o *rolePlayerList; // x8
  int v4; // w9
  System_Collections_Generic_List_RoleBehaviour__o *roleEnemyList; // x8

  v2 = self;
  if ( (byte_9000BE3 & 1) == 0 )
  {
    self = (GameModule_HexBehaviour_o *)((__int64 (__fastcall *)(void *, const MethodInfo *))unk_3C3D280)(
                                          &unk_8D0DDC0,
                                          method);
    byte_9000BE3 = 1;
  }
  if ( v2->fields.isOpened == 0 )
  {
    rolePlayerList = v2->fields._rolePlayerList;
    if ( rolePlayerList != nullptr )
    {
      v4 = *((_DWORD *)rolePlayerList + 6);
      if ( v4 < 1 )
      {
        roleEnemyList = v2->fields._roleEnemyList;
        if ( v4 != 0 )
        {
          if ( roleEnemyList != nullptr )
          {
LABEL_16:
            if ( *((int *)roleEnemyList + 6) >= 1 && v2->fields.isEnemyHex == 0 )
              GameModule_HexBehaviour__EncroachmentPlayer(v2, method);
            return;
          }
        }
        else if ( roleEnemyList != nullptr )
        {
          if ( *((_DWORD *)roleEnemyList + 6) == 0 )
            return;
          goto LABEL_16;
        }
      }
      else
      {
        roleEnemyList = v2->fields._roleEnemyList;
        if ( roleEnemyList != nullptr )
        {
          if ( *((int *)roleEnemyList + 6) > 0 )
            return;
          if ( v2->fields.isEnemyHex != 0 )
          {
            GameModule_HexBehaviour__EncroachmentEnemy(v2, method);
            return;
          }
          goto LABEL_16;
        }
      }
    }
    ((void (__fastcall *)(GameModule_HexBehaviour_o *, const MethodInfo *))unk_3C3D4CC)(self, method);
    JUMPOUT(0x44299B0);
  }
}
