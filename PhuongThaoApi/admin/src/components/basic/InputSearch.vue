<template>
    <div class="search">
        <div class="search-icon">
            <img src="../../assets/icon/search.png" alt="" srcset="">
        </div>
        <div class="search-input">
            <input type="text" data-toggle="tooltip" title="Không được để trống!" placeholder="Tìm kiếm theo Mã, Tên khác" name="txtSearch" id="txtSearch">
        </div>
    </div>
</template>
<script>
export default {
    
}
</script>
<style scoped>
.search{
    margin-left: 16px;
    border: 1px solid #bbbbbb;
    width: 250px;
    height: 40px;
    border-radius: 4px;
    color: black;
    line-height: 44px;
    display: flex;
    justify-content: flex-start;
}
    .search .search-icon img{
        margin-left: 16px;
        justify-content: flex-start;
        cursor: pointer;
        margin-right: 5px;
    }
    .search .search-input input{
        outline: none;
        border: none;
        font-size: 12px;
        width: 160px;
        justify-content: flex-end;
        position: relative;
        top: -3px;
    }

</style>