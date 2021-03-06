#pragma once
#include "DBDefine.h"
#include "CharBuffer.h"
#include "DBTableDefine.h"
#include "RoleInfoDefine.h"

class GameRoleDefine :
    public DBDefine
{
public:
    static const DBTableDefine& GetDefine()
    {
        static const DBTableDefine TheTable
        {
            "game_role",false,"id","name",
            {
                { "id",enum_field_types::MYSQL_TYPE_LONG,0,true,false },
                { "name",enum_field_types::MYSQL_TYPE_VARCHAR,Default::NameSize,false,false },
                { "vip",enum_field_types::MYSQL_TYPE_LONG,0,false,false },
                { "level",enum_field_types::MYSQL_TYPE_LONG,0,false,false,1 },
                { "sex",enum_field_types::MYSQL_TYPE_BIT,0,false,false },
                { "job",enum_field_types::MYSQL_TYPE_SHORT,0,false,false },
                { "borntime",enum_field_types::MYSQL_TYPE_DATETIME,0,false,false },
            },
        };

        return TheTable;
    }

    virtual const char* table() override
    {
        return GetDefine().tableName();
    }

public://游戏基本系统
    RoleStat::Base base;
    RoleStat::Bag bag;
    RoleStat::Equip equip;
    RoleStat::Store store;
    RoleStat::Mail mail;

public://游戏内容
    RoleStat::Env env;
    RoleStat::Member member;
    RoleStat::Group group;
    RoleStat::Awareness awareness;
    RoleStat::Gene gene;
    RoleStat::MileStone mileStone;
    RoleStat::Teachnology teachnology;

public:
    virtual const char* key() override
    {
        return GetDefine().key();
    }
    virtual const char* key2() override
    {
        return GetDefine().key2();
    }


    virtual void serializeForUpdate(stringstream& ss) override
    {
        startConcat(ss, GetDefine(), id);
        concat(ss, GetDefine(), base.name);
        concat(ss, GetDefine(), base.vip);
        concat(ss, GetDefine(), base.level);
        concat(ss, GetDefine(), base.sex);
        concat(ss, GetDefine(), base.job);
        concat(ss, GetDefine(), base.borntime);
    }

    virtual void deserializeMe() override
    {
        stream() >> id;
        stream() >> base.name;
        stream() >> base.vip;
        stream() >> base.level;
        stream() >> base.sex;
        stream() >> base.job;
        stream() >> base.borntime;
    }

    virtual void serializeMe() override
    {
        stream() << id;
        stream() << base.name;
        stream() << base.vip;
        stream() << base.level;
        stream() << base.sex;
        stream() << base.job;
        stream() << base.borntime;
    }
};


