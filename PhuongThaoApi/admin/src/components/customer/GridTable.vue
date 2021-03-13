<template>
    <div class="grid">
        <table>
            <tr>
                <th class="center">STT</th>
                <th class="left">Họ và tên</th>
                <th class="center">Giới tính</th>
                <th class="left">Ngày sinh</th>
                <th class="left">Điện thoại</th>
                <th class="left">Email</th>
                <th class="right">Lương</th>
                <th class="right">Mã thẻ thành viên</th>
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
                            <td rowspan="1" colspan="1" class="left">BuiCongNam1999@gmail.com</td>
                            <td rowspan="1" colspan="1" class="right">20.000.000</td>
                            <td rowspan="1" colspan="1" class="right">0545456</td>
                        </tr>
                    </tbody>
            </table>
        </div>
        <grid-paging />
    </div>
</template>

<script>
import GridPaging from './GridPaging.vue'
export default {
  components: { GridPaging },
    
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