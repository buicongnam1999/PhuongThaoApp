<template>
    <div :class="{isHide: isHide}">
        <div class="ui-dialog">
            <div class="ui-dialog-content">
                <div class="ui-dialog-title">
                    <div class="dialog-text">
                        <b>Ghi tăng Khách hàng</b>
                    </div>
                    <div class="dialog-setting">
                        <div class="dialog-help">
                            <img src="../../assets/icon/help.svg" alt="" srcset="">
                        </div>
                        <div class="dialog-close">
                            <img src="../../assets/icon/cancel.svg" alt="" srcset="" @click="close">
                        </div>
                    </div>
                </div>
                <div class="ui-dialog-form">
                    <form action="">
                        <div class="form-element">
                            <div class="element-left">
                                <div><label for="">Tên khách hàng(*) <i style="color: red" v-if="codeNull">{{messageNull}}</i></label></div>
                                <div :class="{res: res}">
                                    <div class="dialog-input" style="margin-top: 10px">
                                        <input type="text" name="txtAssetCode">
                                    </div>
                                </div>
                            </div>
                            <div class="element-right">
                                <div><label for="">Tên tài khoản(*)</label><i style="color: red" v-if="nameNull">{{messageNull}}</i></div>
                                <div class="dialog-input" style="margin-top: 10px">
                                    <input type="text" name="txtAssetNam">
                                </div>
                            </div>
                        </div>
                        <div class="form-element"  style="margin-top: 15px;">
                            <div class="element-left">
                                <div><label for="">Giới tính<i style="color: red" v-if="codeDepart">{{messageNull}}</i></label></div>
                                <div  class="dialog-input" style="margin-top: 10px">
                                    <select name="" id="" @change="onChange($event)">
                                        <option value="" selected>Giới tính</option>
                                        <option v-for="(department, index) in Departments" :key="index" :value="department.departmentId">{{department.departmentCode}}</option>
                                    </select>
                                </div>
                            </div>
                            <div class="element-right">
                                <div><label for="">Số điện thoại</label></div>
                                <div  class="dialog-input"  style="margin-top: 10px">
                                    <input type="text" name="">
                                </div>
                            </div>
                        </div>
                        <div class="form-element" style="margin-top: 15px">
                            <div class="element-left">
                                <div><label for="">Địa chỉ <i style="color: red" v-if="codeType">{{messageNull}}</i></label></div>
                                <div  class="dialog-input"  style="margin-top: 10px">
                                    <input type="text" name="txtAssetTypeName">
                                </div>
                            </div>
                            <div class="element-right">
                                <div><label for="">Email</label></div>
                                <div  class="dialog-input"  style="margin-top: 10px">
                                    <input type="text" name="txtAssetTypeName">
                                </div>
                            </div>
                        </div>
                        <div class="footer-form">
                            <div class="footer-form-left">
                                <div class="btn-cancel" @click="close">Hủy</div>
                            </div>
                            <div class="footer-form-right">
                                <div class="btn-add" @click="createAsset()">Lưu</div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</template>
<script>
// import axios from 'axios'

export default {
    props:{
        //Thuộc tính ẩn component
        isHide: Boolean,
        title: String
    },
    name: 'MenuBarLinks',
    components:{
    },
    data() {
        return {
            codeNull : false,
            nameNull : false,
            codeDepart: false,
            codeType: false,
            time: false,
            messageNull : 'không được để trống',
            Asset:{
                assetId: '0494ed18-739c-11eb-8a1f-00163e047e89',
                assetCode: '',
                assetName: '',
                assetTypeId: '185f84ed-4563-51a0-cac7-6c0aeb6ec302',
                departmentId: '3f8e6896-4c7d-15f5-a018-75d8bd200d7c',
                increaseDate: '',
                timeUse: 2020,
                wearRate: 0,
                originalPrice: 0,
                wearValue: 0,
                isUsed: 2,
                createdDate: '0001-01-01T00:00:00',
                createdBy: null,
                modifiedDate: '0001-01-01T00:00:00',
                modifiedBy: null
            },
            Departments:{
                
            },
            AssetTypes:{
                
            },
            res: {
                data: {
                    
                }
            },
            validate: false,
            sucess: false,
            DepartmentId: '',
            AssetTypeId: '',
            DepartmentName: '',
            AssetTypeName: '',
            showDialog: false
        }
    },
    methods: {
        close: function() {
            this.$emit('closeForm')
        }
    },
    
}
</script>
<style scoped>
    /*----------------------
  -------------page dialog--------------  
*/
.ui-dialog{
    background-color: rgba(168, 168, 168, 0.5);
    height: 106vh;
    position: absolute;
    top: 0px;
    left: 0;
    z-index: 1;
    width: 100%;
}

/* Nội dung form */
    .ui-dialog .ui-dialog-content{
        background-color: #ffffff;
        width: 800px;
        height: 400px;
        margin: 80px auto;
    }
        .ui-dialog-title{
            font-size: 15px;
            display: flex;
            width: 100%;
        }
            .dialog-text{
                padding: 10px 20px;
                width: 30%;
            }
            .dialog-setting{
                display: flex;
                width: 70%;
                justify-content: flex-end;
                padding: 15px 20px;

            }
                .dialog-help{
                    margin-right: 10px;
                    cursor: pointer;
                }
                .dialog-close{
                    cursor: pointer;
                }

/* ------------------
----------------Paging-----------------
*/

.paging{
    margin-top: 20px;
    display: flex;
}
.paging-left{
    justify-content: flex-start;
    width: 70%;
}
.paging-right{
    justify-content: flex-end;
    width: 30%;
}


/*--------------
---------------Form---------------
*/
.dialog-input{
    border: 1px solid #e0e0e0;
    padding: 5px;
    height: 34px;
    border-radius: 1px;
}
.dialog-input input{
    outline: none;
    border: none;
    width: 90%;
    margin-left: 5px;
    margin-top: 6px;
    font-size: 14px;
}.dialog-input select{
    margin-top: 10px;
}
    /* Thành phần của form*/
.form-element{
    display: flex;
    width: 100%;
    margin-top: 0px;
}
.element-left{
    margin-left: 20px;
    width: 35%;
}
.element-right{
    margin-left: 20px;
    width: 57%;
}
    .element-right-info{
        display: flex;
        
    }
        .element-right-info .infor-left{
            width: 50%;
        }
        .element-right-info .infor-right{
            width: 50%;
        }
        .element-right-info .dialog-input-persen , .element-right-info .dialog-input-time {
            border: 1px solid #e0e0e0;
            padding: 5px;
            height: 34px;
            border-radius: 1px;
        }
            .element-right-info .dialog-input-persen {
                margin-left: 52px;
                width: 86%;
            }
            .element-right-info .dialog-input-time{
                width: 110%;
            }
        .element-right-info input{
            border: none;
            outline: none;
        }

        /* Chân form */
.footer-form{
    display: flex;
    width: 100%;
    height: 60px;
    background-color: #f5f5f5;
    margin-top: 55px;
    justify-content: space-between;
}
    .footer-form-left{
        margin-top: 15px;
        margin-left: 22px;
    }
    .footer-form-right{
        margin-top: 15px;
        justify-content: flex-end;
        margin-right: 22px;
    }
.btn-cancel,.btn-add{
    cursor: pointer;
}
.btn-cancel:hover,.btn-add:hover{
    color: red;
    opacity: 0.8;
}
select {
    border: none;
    outline: none;
}
select option{
    border: none;
    outline: none;
}
.isHide{
    display: none;
}
</style>