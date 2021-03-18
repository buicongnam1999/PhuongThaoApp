<template>
    <div class="grid">
        <table>
            <tr>
                <th class="center">STT</th>
                <th class="left">Họ và tên</th>
                <th class="center">Giới tính</th>
                <th class="left">Ngày sinh</th>
                <th class="left">Điện thoại</th>
                <th class="left" colspan="2">Email</th>
                <th class="left">Tài khoản</th>
                <th class="right">Chức năng</th>
            </tr>
        </table>
        <div class="table__content">
            <table>
                <tbody>
                        <tr>
                            <td rowspan="1" colspan="1" class="center">
                                1
                            </td>
                            <td rowspan="1" colspan="1" class="left">
                                Bùi Công Nam
                            </td>
                            <td class="center" rowspan="1" colspan="1">Nam</td>
                            <td rowspan="1" colspan="1" class="left">20-09-1999</td>
                            <td rowspan="1" colspan="1" class="left">0387200935</td>
                            <td rowspan="1" colspan="2" class="left">BuiCongNam1999@gmail.com</td>
                            <td rowspan="1" colspan="1" class="left">nam1999@gmail.com</td>
                            <td rowspan="1" colspan="1" class="right">
                                <div class="function">
                                    <div class="function-edit" @click="openForm">
                                        <img src="../../assets/icon/edit.svg" alt="" srcset="">
                                    </div>
                                    <div class="function-delete">
                                        <img src="../../assets/icon/x.svg" alt="" srcset="">
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </tbody>
            </table>
        </div>
        <grid-paging />
        <dialog-employee :isHide="isHide" @closeForm="closeForm"/>
    </div>
</template>

<script>
import DialogEmployee from './DialogEmployee.vue'
import GridPaging from './GridPaging.vue'
export default {
  components: { 
        GridPaging,
        DialogEmployee 
    },
    data() {
        return {
            isHide: true
        }
    },
    methods: {
        openForm: function() {
            this.isHide = !this.isHide
        },
        closeForm: function() {
            this.isHide = !this.isHide
        }
    },
}
</script>

<style scoped>
.grid{
    margin-top: 30px;
}
.grid table{
    width: 100%;
    table-layout: fixed;
}
.grid table tr th{
    font-size: 12px;
}
.grid table tr td{
    font-size: 11px;
    height: 20px;
}
.function{
    display: flex;
    justify-content: flex-end;
}
.function-edit img, .function-delete img{
    width: 20px;
    height: 20px;
    cursor: pointer;
}
.function-delete img:active, .function-edit img:active{
    opacity: 0.3;
}
.table__content{
    overflow-y: auto;
    height: 310px;
}
.center{
    text-align: center;
}
.right{
    text-align: right;
}
.left{
    text-align: left;
}
</style>