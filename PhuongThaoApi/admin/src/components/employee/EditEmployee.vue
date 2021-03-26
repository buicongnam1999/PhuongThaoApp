<template>
    <div :class="{isHideEdit: isHideEdit}">
        <div class="ui-dialog">
            <div class="ui-dialog-content">
                <div class="ui-dialog-title">
                    <div class="dialog-text">
                        <b>Ghi tăng nhân viên</b>
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
                                <div><label for="">Tên nhân viên(*) {{employee.user_phone}}<i style="color: red"></i></label></div>
                                <div>
                                    <div class="dialog-input" style="margin-top: 10px">
                                        <input type="text" name="txtEmployeeName" v-model="employee.user_fullname" :placeholder="employee.user_fullname">
                                        <!-- <span style="padding-left: 10px"><img src="../../assets/content/icon/i_arrow_up_small.svg" alt=""></span> -->
                                    </div>
                                </div>
                            </div>
                            <div class="element-right">
                                <div><label for="">Tên tài khoản(*)</label><i style="color: red"></i></div>
                                <div class="dialog-input" style="margin-top: 10px">
                                    <input type="text" name="txtAssetNam" v-model="employee.u_name">
                                </div>
                            </div>
                        </div>
                        <div class="form-element"  style="margin-top: 15px;">
                            <div class="element-left">
                                <div><label for="">Giới tính<i style="color: red"></i></label></div>
                                <div  class="dialog-input" style="margin-top: 10px">
                                    <select name="" id="" v-model="employee.user_gender">
                                        <option value="" selected>Chọn giới tính</option>
                                        <option v-for="(gender, index) in genders" :key="index" :value="gender.value">{{gender.gender}}</option>
                                    </select>
                                </div>
                            </div>
                            <div class="element-right">
                                <div><label for="">Số điện thoại</label></div>
                                <div  class="dialog-input"  style="margin-top: 10px">
                                    <input type="text" name="" v-model="employee.user_phone">
                                </div>
                            </div>
                        </div>
                        <div class="form-element" style="margin-top: 15px">
                            <div class="element-left">
                                <div><label for="">Địa chỉ <i style="color: red"></i></label></div>
                                <div  class="dialog-input"  style="margin-top: 10px">
                                    <input type="text" name="txtAssetTypeName" v-model="employee.user_address">
                                </div>
                            </div>
                            <div class="element-right">
                                <div><label for="">Email</label></div>
                                <div  class="dialog-input"  style="margin-top: 10px">
                                    <input type="text" name="txtAssetTypeName" v-model="employee.user_email">
                                </div>
                            </div>
                        </div>
                        <div class="footer-form">
                            <div class="footer-form-left">
                                <div class="btn-cancel" @click="close">Hủy</div>
                            </div>
                            <div class="footer-form-right">
                                <div class="btn-add">Lưu</div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</template>
<script>
import { mapActions,mapGetters} from 'vuex'
export default {
    inheritAttrs: false,
    props:{
        //Thuộc tính ẩn component
        isHideEdit: Boolean,
        id: Number,
    },
    name: 'MenuBarLinks',
    components:{
    },
    data() {
        return {
            message : '',
            validate: false,
            genders:[
                {
                    gender: 'Nam',
                    value: 1
                },
                {
                    gender: 'Nữ',
                    value: 2
                }
            ],
            res:false,
        }
    },
    methods: {
        close: function() {
            this.$emit('closeForm')
        },
        reloadData(){
            this.employee.user_fullname = '',
            this.employee.user_gender = 1,
            this.employee.user_phone = '',
            this.employee.user_email = '',
            this.employee.user_address = '',
            this.employee.u_name = '',
            this.employee.user_pass = 'abc@1234',
            this.employee.user_type = 2
        },
        ...mapActions("employees", {loadEmployees: "loadData"})
    },
    computed:{
        ...mapGetters("employees", {employee: "getEmployees"}),
    },
    async created(){
        
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
    height: 25px;
    border-radius: 1px;
}
.dialog-input input{
    outline: none;
    border: none;
    width: 90%;
    margin-left: 5px;
    font-size: 14px;
    margin-top: 3px;
}
.dialog-input option{
    margin-left: 5px;
    font-size: 14px;
    margin-top: 3px;
    list-style: none;
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
.isHideEdit{
    display: none;
}
</style>